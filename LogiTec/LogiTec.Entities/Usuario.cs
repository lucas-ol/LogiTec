using System;
using System.Collections.Generic;
using System.Text;

namespace LogiTec.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }
        public string RG { get; set; }
        public string CNH { get; set; }
        public DateTime Nacimento { get; set; }
        public string Telefones { get; set; }
        public string Email { get; set; }
        public string Logradouro { get; set; }
        public string CEP { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string RedeSocial { get; set; }

        //nome pai telefone pai e mae 
        public string DadosComplementares { get; set; } 
        public string  Login { get; set; }
        public string  Senha { get; set; }
        public byte[] Foto { get; set; }
    }
}
