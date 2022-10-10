using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vasmegye
{
    class Vasmegye
    {
        public List<adatok> adat = new List<adatok>();
        static void CdvEll()
        {



            return ;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nA program kezdődik...");

            /*2.feladat*/
            Console.WriteLine("\n2. feladat: Adatok beolvasása, tárolása");
            StreamReader sr = new StreamReader("vas.txt" ,Encoding.Default);
            while (!sr.EndOfStream)
            {

                adat.Add(new adatok(sr.ReadLine()));

            }
            sr.Close();
            /*4.feladat*/
            Console.WriteLine("\n4. feldat: Ellenőrzés");
            CdvEll();

            /*5.feladat*/
            Console.WriteLine("\nVasmegyében a vizsgált évek alatt");

            Console.WriteLine("\nProgram vége!");
            Console.ReadKey();
        }
    }
}
