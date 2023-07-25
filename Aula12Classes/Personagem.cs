using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Personagem
    {
        //Variáveis (Atributos)
       public string nome;
       public  string raca;
       public  int poder;
       
        //Funções (Métodos)
        public void mostra()
        {
            Console.WriteLine($"Seu personagem é {raca} o nome é {nome} e o poder é {poder}");
        }

    }
}
