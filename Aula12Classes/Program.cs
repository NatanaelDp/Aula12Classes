
using Aula12Classes;

Console.WriteLine("Olá, mundo!");

Personagem guerreiro= new Personagem();
guerreiro.nome = "Rakan";
guerreiro.raca = "Vastaya";
guerreiro.poder = 500;

guerreiro.mostra();
Personagem mago= new Personagem();
mago.raca = "Elfo";
mago.poder = 150;
mago.nome = "Harry";

mago.mostra();

Personagem bruxo = mago;
bruxo.nome = "Hermione";
bruxo.mostra();

Personagem atirador= new Personagem();
atirador.nome = "Jhin";
atirador.raca = "Humano";
atirador.poder = 4444;

atirador.mostra();






Console.ReadKey();

