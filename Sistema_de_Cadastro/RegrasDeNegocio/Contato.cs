using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Cadastro.RegrasDeNegocio
    {
    internal class Contato
    {
        public string Nome { get; set; }
        public string CPF{ get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public DateTime dataNascimento { get; set; }
        public string ToString()
            {
            return $"{Nome};{CPF};{Telefone};{Sexo};{dataNascimento}";
        }

    }
    }
