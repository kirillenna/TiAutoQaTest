using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter coordinate x of dot A: \n");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinate y of dot A: \n");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinate x of dot B: \n");
        double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinate y of dot B: \n");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinate x of dot C: \n");
        double e = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coordinate y of dot C: \n");
        double f = Convert.ToDouble(Console.ReadLine());

        double AB = Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((d - b), 2));
        string output1 = "Length of AB is: ";
        Console.WriteLine(output1 + AB);
        double BC = Math.Sqrt(Math.Pow((e - c), 2) + Math.Pow((f - d), 2));
        string output2 = "Length of BC is: ";
        Console.WriteLine(output2 + BC);
        double AC = Math.Sqrt(Math.Pow((e - a), 2) + Math.Pow((f - b), 2));
        string output3 = "Length of AC is: ";
        Console.WriteLine(output3 + AC);


        if (AB == BC & BC == AC & AB==AC)
        {
            Console.WriteLine("\nTriangle IS 'Equilateral'");
        }
        else
        {
            Console.WriteLine("\nTriangle IS NOT 'Equilateral'");
        }

        if (AB == BC || BC == AC || AB == AC)
        {
            Console.WriteLine("Triangle IS 'Isosceles'");
        }
        else
        {
            Console.WriteLine("Triangle IS NOT 'Isosceles'");
        }

        if (Math.Sqrt(AB) == Math.Sqrt(BC) + Math.Sqrt(AC) || Math.Sqrt(BC) == Math.Sqrt(AB) + Math.Sqrt(AC) || Math.Sqrt(AC) == Math.Sqrt(BC) + Math.Sqrt(AB))
        {
            Console.WriteLine("Triangle IS 'Right'");
        }
        else
        {
            Console.WriteLine("Triangle IS NOT 'Right'");
        }

        double P = AB + AC + BC;
        Console.WriteLine("\nPerimeter: " + P);

        int P1 = Convert.ToInt32(P);
        Console.WriteLine("\nParity numbers in Range from 0 to triangle perimeter:");
        for (int i = 0; i<=P1+1; i++)
        { if(i%2 == 0)
            {
                Console.Write(i + "\n");
            } 
        }
    }
}