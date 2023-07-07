using System;
class Program
{
    static void Main(string[] args)
    {
        string[] Aplus = {"A+", "Sobresaliente Alto"};
        string[] A = {"A", "Sobresaliente"};
        string[] Bplus = {"B+", "Notable Alto"};
        string[] B = {"B", "Notable"};
        string[] Bminus = {"B-", "Notable Bajo"};
        string[] Cplus = {"C+", "Bien"};
        string[] C = {"C", "Suficiente"};
        string[] Cminus = {"C-", "Suficiente Bajo"};
        string[] Dplus = {"D+", "Insuficiente"};
        string[] D = {"D", "Insuficiente"};
        string[] Dminus = {"D-", "Insuficiente"};
        string[] F = {"F", "Insuficiente"};
        int grade = 0;
        int i = 0;
        
        while (i == 0)
        {
            Console.WriteLine("Ingrese el valor de la nota: ");
            string input = Console.ReadLine();
            grade = int.Parse(input);

            if (grade < 0)
            {
                Console.WriteLine("¡El valor debe estar entre 0 y 100!");
                Console.WriteLine();
            }
            else if (grade > 100)
            {
                Console.WriteLine("¡El valor debe estar entre 0 y 100!");
                Console.WriteLine();
            }
            else
            {
                i++;
            }
        }

        if (grade >= 93)
        {
            foreach (string calificacion in Aplus)
            {
            Console.WriteLine(calificacion);
            }
        }
        else if (grade >= 90)
        {
            foreach (string calificacion in A)
            {
                Console.WriteLine(calificacion);
            }
        }
        else if (grade >= 87)
        {
            foreach (string calificacion in Bplus)
            {
                Console.WriteLine(calificacion);
            }
        }
        else if (grade >= 83)
        {
            foreach (string calificacion in B)
            {
                Console.WriteLine(calificacion);
            }
        }
        else if (grade >= 80)
        {
            foreach (string calificacion in Bminus)
            {
                Console.WriteLine(calificacion);
            }        
        }
        else if (grade >= 77)
        {
            foreach (string calificacion in Cplus)
            {
                Console.WriteLine(calificacion);
            }       
        }
        else if (grade >= 73)
        {
            foreach (string calificacion in C)
            {
                Console.WriteLine(calificacion);
            }        
        }
        else if (grade >= 70)
        {
            foreach (string calificacion in Cminus)
            {
                Console.WriteLine(calificacion);
            }        
        }
        else if (grade >= 67)
        {
            foreach (string calificacion in Dplus)
            {
                Console.WriteLine(calificacion);
            }        
        }
        else if (grade >= 63)
        {
            foreach (string calificacion in D)
            {
                Console.WriteLine(calificacion);
            }        
        }
        else if (grade >= 60)
        {
            foreach (string calificacion in Dminus)
            {
                Console.WriteLine(calificacion);
            }        
        }
        else
        {
            foreach (string calificacion in F)
            {
                Console.WriteLine(calificacion);
            }        
        }
    }
}