using System;
namespace View {

 public class Dog {

  private string nome;
  private int fome;
  private int saude;
  private int idade;
  private int felicidade;
  private int cansaco;


// Construtor -----------
  public Dog() {

   Random rnd = new Random();
   this.setSaude(rnd.Next(70, 90));

   this.setFelicidade(rnd.Next(80, 95));

   this.setFome(rnd.Next(30, 50));

   this.setCansaco(rnd.Next(10, 50));

   this.setIdade(rnd.Next(1, 4));

   Dog.Desenho();
   Console.WriteLine("Dê um nome para o bichinho: ");
   this.setNome(Console.ReadLine());
   Console.WriteLine("***************");

   Console.Clear();

   Console.WriteLine("Você acabou de adotar o(a) {0}.", this.getNome());
   Dog.Desenho();

   Console.WriteLine("Saude: {0}%", this.getSaude());

   Console.WriteLine("Felicidade: {0}%", this.getFelicidade());

   Console.WriteLine("Fome: {0}%", this.getFome());

   Console.WriteLine("Cansaço: {0}%", this.getCansaco());

   if (this.getIdade() > 1) {
    Console.WriteLine("Idade: {0} anos", this.getIdade());
   } else {
    Console.WriteLine("Idade: {0} ano", this.getIdade());
   }
  }

  // Get Set

  public string getNome() {
   return nome;
  }

  public void setNome(string nome) {
   this.nome = nome;
  }

  public int getFome() {
   return fome;
  }

  public void setFome(int fome) {
   this.fome = fome;
  }

  public int getSaude() {
   return saude;
  }

  public void setSaude(int saude) {
   this.saude = saude;
  }

  public int getIdade() {
   return idade;
  }

  public void setIdade(int idade) {
   this.idade = idade;
  }

  public int getFelicidade() {
   return felicidade;
  }

  public void setFelicidade(int felicidade) {
   this.felicidade = felicidade;
  }

  public int getCansaco() {
   return cansaco;
  }

  public void setCansaco(int cansaco) {
   this.cansaco = cansaco;
  }

  // Funções

  public void Comer() {

   if (getFome() <= 0) {

    this.saude = getSaude() - 5;
    this.felicidade = getFelicidade() - 5;

   } else {
    this.fome = getFome() - 10;
    this.felicidade = getFelicidade() + 5;
    this.saude = getSaude() + 5;
   }

  }

  public void Brincar() {

   if (getFelicidade() >= 100) {
    this.felicidade = getFelicidade() - 5;
    this.saude = getSaude() - 5;
    this.fome = getFome() + 10;
    this.cansaco = getCansaco() + 10;

   } else {
    this.felicidade = getFelicidade() + 5;
    this.saude = getSaude() + 5;
    this.fome = getFome() + 5;
    this.cansaco = getCansaco() + 5;
   }

  }

  public void Dormir() {

   if (getCansaco() <= 0) {
    this.saude = getSaude() - 5;
    this.felicidade = getFelicidade() - 5;
    this.fome = getFome() + 5;
   } else {
    this.cansaco = getCansaco() - 5;
    this.felicidade = getFelicidade() + 5;
    this.saude = getSaude() + 5;
    this.fome = getFome() + 5;

   }

  }

  //VIEW DO TAMAGUCHI --------------

  public static void Desenho() {
   Console.WriteLine(" ");
   Console.WriteLine("***************");
   Console.WriteLine(" __       _");
   Console.WriteLine("o'')}____//");
   Console.WriteLine(" `_/      )");
   Console.WriteLine(" (_(_/-(_/");
   Console.WriteLine("***************");
  }

  public static void Desenho2() {
   Console.WriteLine(" ");
   Console.WriteLine("***************");
   Console.WriteLine("    .-.");
   Console.WriteLine("  __| |__");
   Console.WriteLine(" [__   __]");
   Console.WriteLine("    | |");
   Console.WriteLine("    | |");
   Console.WriteLine("    | |");
   Console.WriteLine("    '-'");
   Console.WriteLine("***************");

  }

 }
}