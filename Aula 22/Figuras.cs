using System;

class MainClass {
  public static void Main (string[] args) {
    Figura f1 = new Circulo("Azul", 10);
    Figura f2 = new Triangulo("Vermelho", 20, 40);
    Console.WriteLine(f1.GetCor());
    Console.WriteLine(f1.GetArea());
    Console.WriteLine(f2.GetCor());
    Console.WriteLine(f2.GetArea());

    //Classe Figura não pode ser instanciada pois é uma classe abstrata.
    //Figura f3 = new Figura("Teste");
  }
}

abstract class Figura {
  private string cor;
  public Figura(string cor) {
    this.cor = cor;
  }
  public string GetCor() {
    return cor;
  }
  public abstract double GetArea();
}

class Circulo : Figura {
  private double r;
  public Circulo(string cor, double r) :
    base(cor) {
      this.r = r;
  }
  public override double GetArea() {
    return Math.PI * r * r;
  }
}

class Triangulo : Figura {
  private double b, h;
  public Triangulo(string cor, double b, double h) : base(cor) {
    this.b = b;
    this.h = h;
  }
  public override double GetArea() {
    return b * h / 2;
  }
}