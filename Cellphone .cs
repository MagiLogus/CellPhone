using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellPhone
{
    public class Cellphone 
    {
       public string Modelo;
        public string Cor;
        public string Tamanho;
        public bool Ligado;

        public void Ligar()
        {
            Console.WriteLine($"Celular ligado!");
            Ligado = true;
        }

        public void Desligar()
        {
            Console.WriteLine($"Celular desligado!");
            Ligado = false;
            
        }

        public void FazerLigacao(string numero)
        {
            if (Ligado == true)
            {
                Console.WriteLine($"Ligando para {numero}.");
                
            }
            else
            {
                Console.WriteLine($"Celular desligado!");
                
            }
        }

        public void EnviarMensagem(string mensagem)
        {
            if (Ligado == true)
            {
                Console.WriteLine($"Enviando mensagem: {mensagem}");
                
            }
            else
            {
                Console.WriteLine($"Celular desligado!");
                
            }
    }
    }      
}