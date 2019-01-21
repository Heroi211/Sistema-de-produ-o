using System;
using System.Collections.Generic;

namespace SistemaDeProducao
{
    class Vendedores
    {
        public string name { get; set; }
        public int id { get; set; }
        public string email { get; set; }
        public string CPF { get; set; }

        public Vendedores(string name, int id, string email, string CPF)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.CPF = CPF;
        }

        public override string ToString()
        {
            return "Vendedor: " + name +
             ", ID: " + id +
             ", E-mail: " + email +
             ", CPF: " + CPF;
        }
    }
}
