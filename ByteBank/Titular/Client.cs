using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Client
    {
        public string name;
        public string cpf;
        public string profession;
        public Client(string name,string cpf) 
        {
            this.name = name;
            this.cpf = cpf;
        }
        public Client(string name, string cpf, string profession)
        {
            this.name = name;
            this.cpf = cpf;
            this.profession = profession;
        }

    }
}
