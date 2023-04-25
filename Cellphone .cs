using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellPhone
{
    public class Cellphone 
    {
        public string Cor;
        public string Modelo;
        public float Tamanho;
        public bool Ligado;
    }
        public void Ligar()
        {
        this.Ligado = true;
        Console.WriteLine("O celular está ligado.");
        }
}