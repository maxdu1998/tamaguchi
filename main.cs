using System;

namespace View {

 class MainClass {

  public static void Main() {

   Dog s = new Dog();

   for (int i = s.getIdade(); s.getSaude() >= 0 && s.getIdade() <= 15; i++) {

    s.setIdade(i);
    Console.WriteLine("***************");
    Console.WriteLine("Brincar, Comer ou Dormir?");
    string step = (Console.ReadLine());

    if (step == "comer") {
     s.Comer();
    }

    if (step == "brincar") {
     s.Brincar();
    }

    if (step == "dormir") {
     s.Dormir();
    }

    Console.Clear();

    Dog.Desenho();

    Console.WriteLine("Saude: {0}%", s.getSaude());

    Console.WriteLine("Felicidade: {0}%", s.getFelicidade());

    Console.WriteLine("Fome: {0}%", s.getFome());

    Console.WriteLine("Cansaço: {0}%", s.getCansaco());

    if (s.getIdade() > 1) {
     Console.WriteLine("Idade: {0} anos", s.getIdade());
    } else {
     Console.WriteLine("Idade: {0} ano", s.getIdade());
    }


   }

   if (s.getIdade() >= 16 || s.getSaude() <= -1) {
    Console.Clear();
    Dog.Desenho2();
    Console.WriteLine("{0} morreu.", s.getNome());

   }


  }
 }
}