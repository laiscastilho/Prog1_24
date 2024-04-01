using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio.Models
{
    public class Imovel
    {
        public int ID { get; set; }
        public string Endereco { get; set; }
        public string Negociacao { get; set; }
        public string Tipo { get; set; }
        public float Valor { get; set; }
        public int Quartos { get; set; }
        public string Localizacao { get; set; }
        public List<string> Imagens = new List<string>();
    }
}