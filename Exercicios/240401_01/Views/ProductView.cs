using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_01.Views
{
    public class ProductView
    {
        
    public ProductView()
        {
            this.Init();
        }
        
        public void Init()
        {
            Console.WriteLine("MENU PRODUCT");
            Console.WriteLine("*************");
            Console.WriteLine("");

            bool aux = true;
            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Inserir Produto");
                Console.WriteLine("2 - Pesquisar Produtos");
                Console.WriteLine("3 - Listar Produtos");
                Console.WriteLine("0 - Sair");

                int menu = 0;
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    switch(menu)
                    {
                        case 0:
                            aux = false;
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            aux = true;
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Opção Inválida");
                    menu = -1;
                }

            }while(aux);
        }
    }
}