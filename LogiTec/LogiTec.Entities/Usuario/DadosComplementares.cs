using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Entities.Usuario
{
    public class DadosComplementares
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public int Usuario_Id{ get; set; }
        public virtual Usuario Usuarios { get; set; }
}
}
