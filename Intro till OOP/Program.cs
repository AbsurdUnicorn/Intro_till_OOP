//SUT26 Pierre Jarl

namespace Intro_till_OOP;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(5.0);
        Console.WriteLine($"Arean av en cirkel med radien 5 är: {circle1.GetArea()}");
       
        Console.WriteLine();
        
        Circle circle2 = new Circle(6.0);
        Console.WriteLine($"Arean av en cirkel med radien 6 är: {circle2.GetArea()}");
        Console.ReadKey();
    }
}

class Circle
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}