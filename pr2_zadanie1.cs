using System;

class QuadraticEquationSolver
{
    private double a, b, c;
    private double root1, root2;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        CalculateRoots();
    }

    private double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    private void CalculateRoots()
    {
        double discriminant = CalculateDiscriminant();

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else if (discriminant == 0)
        {
            root1 = root2 = -b / (2 * a);
        }
        else
        {
            root1 = root2 = double.NaN; 
        }
    }

    public double GetRoot1()
    {
        return root1;
    }

    public double GetRoot2()
    {
        return root2;
    }
}

class pr2_zadanie1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты a, b и c для квадратного уравнения (ax^2 + bx + c = 0):");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        QuadraticEquationSolver solver = new QuadraticEquationSolver(a, b, c);

        double root1 = solver.GetRoot1();
        double root2 = solver.GetRoot2();

        if (!double.IsNaN(root1) && !double.IsNaN(root2))
        {
            Console.WriteLine($"Корень 1: {root1}");
            Console.WriteLine($"Корень 2: {root2}");
        }
        else if (double.IsNaN(root1))
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
    }
}
