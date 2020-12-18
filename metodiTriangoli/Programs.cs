using System;
using TriangoliLibreria;

namespace metodiTriangoli
{
    class Programs
    {
        static void Main(string[] args)
        {
            double l1 = Metodo.Lato();
            double l2 = Metodo.Lato();
            double l3 = Metodo.Lato();
            double perimetro = Metodo.CalcolaPerimetro(l1, l2, l3);
            string risultato = Metodo.ClassificaTriangolo(l1, l2, l3);
            if (l1 < 0 || l2 < 0 || l3 < 0)
            {
                Console.WriteLine("errore!:");
            }
            else
            {
                Console.WriteLine($"PERIMETRO={perimetro}");
            }
        }
    }
}
