using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_03
{
    public class Fornecedores : IComparable<Fornecedores>
    {
        
        public string nome { get; set; }

        public string cnpj { get; set; }

        public string razaoSocial { get; set; }

        public string ie { get; set; }

        public string endereco { get; set; }

        public string cep { get; set; }

        public string cidade { get; set; }

        public string telefone { get; set; }

        public string email { get; set; }

        public string responsavel { get; set; }

        int IComparable<Fornecedores>.CompareTo(Fornecedores dado)
        {
            return this.nome.CompareTo(dado.nome);
        }
    }

    

    
}
