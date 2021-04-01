using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP
{
    public class EsdadoComportamento
    {
        public class Pessoa
        {
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }

            public int CalcularIdade() 
            {
                var dataAtual = DateTime.Now;

                return 0;
                

            }

        }
    }
}
