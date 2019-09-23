const gulp = require('gulp');
const sass = require('gulp-sass');
const babel = require('gulp-babel');
const uglify = require('gulp-uglify');
const bs = require('browser-sync').create();
const autoprefixer = require('autoprefixer');
const postcss = require('gulp-postcss');
const pumbler = require('gulp-plumber');

const resource = {
    css: { src: "./Assets/scss/**/*.scss", dest: './wwwroot/css/' },
    js: { src: "./Assets/js/**/*.js", dest: './wwwroot/js/' }
};

const generalSources = [
    '!node_modules',
    '/Views/**/*.cshtml',
    'js/**/*.js'
];

const processors = [
    autoprefixer({
        bss: ['last 3 versions', 'ie > 9']
    })
];


gulp.task('build:css', () => {
    return gulp.src(resource.css.src)
        .pipe(sass({ outputStyle: 'compressed', }))
        .pipe(pumbler())
        .pipe(postcss(processors))
        .pipe(bs.stream())
        .pipe(gulp.dest(resource.css.dest));
});

gulp.task('build:js', () => {
    return gulp.src(paths.js.src)
        .pipe(babel({
            presets: ['@babel/preset-env']
        }))
        .pipe(uglify())
        .pipe(pumbler())
        .pipe(bs.stream())
        .pipe(gulp.dest(paths.js.dest));
});

gulp.task('compile:js', () => {
    return gulp.src(resource.js.src)
        .pipe(babel({
            presets: ['@babel/preset-env']
        }))
        .pipe(pumbler())
        .pipe(bs.stream())
        .pipe(gulp.dest(resource.js.dest));
});

gulp.task('compile:css', () => {

    return gulp.src(resource.css.src)
        .pipe(sass({ outputStyle: 'compact'}))
        .pipe(pumbler())
        .pipe(postcss(processors))
        .pipe(bs.stream())
        .pipe(gulp.dest(resource.css.dest));
});


gulp.task('default', () => {
    bs.init({
        proxy: "https://localhost:5001"
    });

    gulp.watch(resource.css.src, gulp.series('compile:css'));
    gulp.watch(resource.js.src, gulp.series('compile:js'));
    gulp.watch(generalSources).on('change', bs.reload);
});

gulp.task('build', gulp.series('build:css', gulp.series('build:js', '')));


