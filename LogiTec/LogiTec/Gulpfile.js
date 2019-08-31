const gulp = require('gulp');
const sass = require('gulp-sass');

const resource = {
    sass: { src: "./Assets/scss/**/*.scss", dest:'./wwwroot/css/'},
    js: ""
};
gulp.task("compile:sass", () => {
    return gulp
        .src(resource.sass.src)
        .pipe(sass())
        .pipe(gulp.dest(resource.sass.dest));
});


