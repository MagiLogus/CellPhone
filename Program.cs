//Faça em sua máquina utilizando os mesmos conceitos dado em aula.
//Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
//Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
//Só será possível executar tais métodos se o celular estiver ligado.
//Envie o link do repositório como entrega desta atividade.


using System;

public class Celular
{
    public string cor;
    public string modelo;
    public double tamanho;
    private bool ligado;

    public Celular(string cor, string modelo, double tamanho)
    {
        this.cor = cor;
        this.modelo = modelo;
        this.tamanho = tamanho;
        this.ligado = false;
    }

    public void Ligar()
    {
        this.ligado = true;
        Console.WriteLine("O celular está ligado.");
    }

    public void Desligar()
    {
        this.ligado = false;
        Console.WriteLine("O celular está desligado.");
    }

    public void FazerLigacao(string numero)
    {
        if (this.ligado)
        {
            Console.WriteLine("Ligando para " + numero + "...");
        }
        else
        {
            Console.WriteLine("O celular está desligado. Não é possível fazer uma ligação.");
        }
    }

    public void EnviarMensagem(string numero, string mensagem)
    {
        if (this.ligado)
        {
            Console.WriteLine("Enviando mensagem para " + numero + ": " + mensagem);
        }
        else
        {
            Console.WriteLine("O celular está desligado. Não é possível enviar uma mensagem.");
        }
    }
}