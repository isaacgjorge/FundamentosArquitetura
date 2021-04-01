using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Casa
    {
        /*
         * Definicao de Classe 
             Estrutura de dados/informacao que represente alguma coisa no mundo real
         */

        public class Casa 
        {
            public int TamanhoM2 { get; set; }

            public int Andares { get; set; }

            public decimal Valor { get; set; }

            public int NumeroVagas { get; set; }
        }

        public class Objeto
        {
            public Objeto()
            {
                /*Definicao de Objeto
                    Quando se tem uma classe sendo instanciada. 
                  Ela passa a ser representada na memoria como um objeto
                  Agora ela passa a ter valores

                 */

                var casa = new Casa { 
                    TamanhoM2 = 1000,
                    Andares = 2,
                    Valor = 100000,
                    NumeroVagas = 3
                };
            }
        }
    }
}
