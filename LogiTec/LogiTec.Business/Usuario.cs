using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Business
{
    public class Usuario : IDisposable
    {

        public Utils.FeedBack Cadastrar(Entities.Usuario usuario)
        {
            using (var ctx = new Data.ModelContext())
            {
                ctx.Usuarios.Add(usuario);
            }
            return new Utils.FeedBack();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
