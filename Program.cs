using System;

class Triangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public double AngleA { get; set; }
    public double AngleB { get; set; }
    public double AngleC { get; set; }
    public void InputSides()
    {
        Console.WriteLine("Введіть сторону a (усі сторони рівні):");
        SideA = double.Parse(Console.ReadLine());
        SideB = SideA;
        SideC = SideA;


        AngleA = AngleB = AngleC = 60;
    }


    public void Perimeter()
    {
        double P = SideA + SideB + SideC;
        Console.WriteLine($"Периметр трикутника: {P}");
    }


    class Triangle1 : Triangle
    {
        public double angle { get; set; }


        public void InputSide1()
        {
            Console.WriteLine("Введіть сторону a:");
            SideA = double.Parse(Console.ReadLine());
        }

        public void InputAngle1()
        {
            Console.WriteLine("Введіть перший кут (A1):");
            AngleA = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другий кут (B1):");
            AngleB = double.Parse(Console.ReadLine());

            AngleC = 180 - (AngleA + AngleB);
        }


        public void CalculateOtherSides()
        {
            double radA = AngleA * Math.PI / 180;
            double radB = AngleB * Math.PI / 180;
            double radC = AngleC * Math.PI / 180;

            SideB = SideA * Math.Sin(radB) / Math.Sin(radA);
            SideC = SideA * Math.Sin(radC) / Math.Sin(radA);
        }


        public void Perimeter1()
        {
            double P = SideA + SideB + SideC;
            Console.WriteLine($"Периметр трикутника: {P}");
        }

        public void DisplayInfo1()
        {
            Console.WriteLine($"Сторони: a={SideA}, b={SideB}, c={SideC}");
            Console.WriteLine($"Кути: A={AngleA}, B={AngleB}, C={AngleC}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Рівносторонній трикутник ===");
            Triangle t1 = new Triangle();
            t1.InputSides();
            t1.Perimeter();

            Console.WriteLine("\n=== Трикутник із заданою стороною і двома кутами ===");
            Triangle1 t2 = new Triangle1();
            t2.InputSide1();
            t2.InputAngle1();
            t2.CalculateOtherSides();
            t2.DisplayInfo1();
            t2.Perimeter1();
        }
    }
}
