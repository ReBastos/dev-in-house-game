﻿
var heroi = new Personagem{
    Nome = "Link",
    Vida = 100,
    Armadura = 5,
    Ataque = 5,
};

var teste = new Teste();
teste.Teste2();

var goblim = new Personagem{
    Nome = "Goblim",
    Vida = 10,
    Armadura = 0,
    Ataque = 0,
};


// tomou um hit
var dano = 15;
heroi.Vida = heroi.Vida - dano;


Console.WriteLine($"Olá {heroi.Nome}, você tem {heroi.Vida} de vida.");


// ganhou uma poção de cura


Console.WriteLine($"Olá {heroi.Nome}, você tem {heroi.Vida} de vida.");

void Maca(Personagem heroi){
    
    heroi.Vida = heroi.Vida + 5;
    Console.WriteLine($"{heroi.Nome} consome uma maça, restaurando 5 pontos de vida. Vida autal: {heroi.Vida}");

}

void PocaodeCura(Personagem heroi){
    
    heroi.Vida = heroi.Vida + 30;
    Console.WriteLine($"{heroi.Nome} consome uma poção de cura, restaurando 30 pontos de vida. Vida autal: {heroi.Vida}");

}

void Armadilha(Personagem heroi){

    heroi.Vida = heroi.Vida - 7;
    Console.WriteLine($"{heroi.Nome} encontrou uma armadilha no caminho, recebendo 7 pontos de dano. Vida autal: {heroi.Vida}");

}

void SimpleSword(Personagem heroi){

    heroi.Ataque = heroi.Ataque + 1;
    Console.WriteLine($"{heroi.Nome} encontrou uma espada simples, recebendo mais 1 pontos de ataque.");

}

void GerudosSword(Personagem heroi){

    heroi.Ataque = heroi.Ataque + 3;
    Console.WriteLine($"{heroi.Nome} encontrou uma espada flamejante, recebendo mais 3 pontos de ataque.");

}


void MasterSword(Personagem heroi){

    heroi.Ataque = heroi.Ataque + 7;
    Console.WriteLine($"{heroi.Nome} encontrou a Master Sword, recebendo mais 7 pontos de ataque.");

}

void SimpleShield(Personagem heroi){

    heroi.Armadura = heroi.Armadura + 1;
    Console.WriteLine($"{heroi.Nome} encontrou um escudo simples, recebendo mais 3 pontos de armadura.");

}

void GerudosShield(Personagem heroi){

    heroi.Armadura = heroi.Armadura + 3;
    Console.WriteLine($"{heroi.Nome} encontrou um escudo de Gerudo, recebendo mais 3 pontos de armadura.");

}

void HyrulianShield(Personagem heroi){

    heroi.Armadura = heroi.Armadura + 7;
    Console.WriteLine($"{heroi.Nome} encontrou o Hyrulian Shield, recebendo mais 7 pontos de armadura.");

}

void Helmet(Personagem heroi){

    heroi.Armadura = heroi.Armadura + 2;
    Console.WriteLine($"{heroi.Nome} encontrou um elmo, recebendo mais 2 pontos de armadura.");

}



public class Personagem {
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Armadura { get; set; }

}