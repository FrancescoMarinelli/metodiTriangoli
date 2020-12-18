using System;

namespace TriangoliLibreria
{
    public class Metodo
    {
        public static double Lato()
        {
            Console.WriteLine("Inserire la lunghezza del lato: ");
            double l = double.Parse(Console.ReadLine());
            return l;
        }
        public static string ClassificaTriangolo(double l1, double l2, double l3)
        {
            string risultato = "";
            if (l1 > 0 && l2 > 0 && l3 > 0)
            {
                if (l1 != l2 && l1 != l3 && l2 != l3)
                {
                    Console.WriteLine("triangolo scaleno");
                }
                else if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("triangolo equilatero");
                }
                else
                    Console.WriteLine("triangolo isoscele");
            }
            else
                Console.WriteLine("dati errati");
            return risultato;
        }

        public static double CalcolaPerimetro(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }
    }
}

