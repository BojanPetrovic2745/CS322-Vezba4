using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_Vezba4_BojanPetrovic2745
{
    class Program
    {

        class Class1
        {
            public int Value = 0;
        }

        public class ModifikatoriPristupa
        {
            public int celobrojnaVrednost = 1;

            private void pristupiPoljuIzKlase()
            {
                celobrojnaVrednost++;
            }
        }

        public class TestKlasa
        {
            private void pristupiPoljuIzKlase()
            {
                ModifikatoriPristupa instance = new ModifikatoriPristupa();
                instance.celobrojnaVrednost = 1;
            }
        }

        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = val1;

            val2 = 200;

            Class1 ref1 = new Class1();
            Class1 ref2 = ref1;
           

            ref2.Value = 200;

            int x = 13;
            int brojac = 1;

            decimal a = 123123.5123m;
            decimal b = 123321.123421m;

            Console.WriteLine("Values: {0}, {1}", val1, val2); 
            Console.WriteLine("Refs: {0}, {1}", ref1.Value, ref2.Value);


            if (x < 6)
            {
                System.Console.WriteLine("Manji od sest.");
            }
            else if (x >= 6 && x <= 13)
            {
                System.Console.WriteLine("U opsegu je od 6 do 13");
            }
            else
            {
                System.Console.WriteLine("Veci je od 13.");
            }

           if (x > 0)
           {
                if (brojac < 2)
                {
                    brojac = 6;
                }
                else
                {
                    brojac = 0;
                }
            }

            //primerSwitch(6);

            // za Samostali rad

            Math.Max(1, 2);
            Math.Min(1, 2);
            Math.Sqrt(4);
            Math.Abs(-4.7);
            Math.Round(9.99);


            Math.Max(15.2, 21.5);
            Math.Min(10.123, 2.98);
            Math.Sqrt(16.8);

            Math.Max(15.2f, 21.5f);
            Math.Min(10.123f, 2.98f);
            Math.Sqrt(16.8f);

            Math.Max(a, b);
            Math.Min(a, b);



            Console.WriteLine("Press ENTER to end");

            //Console.Read();

        }


        // static
        public  void primerSwitch(int dan)
        {

            System.Console.WriteLine("Danas je " + dan + " dan u nedelji");

            switch (dan)
            {
                case 1: Console.WriteLine("Ponedeljak"); break;
                case 2: Console.WriteLine("Utorak"); break;
                case 3: Console.WriteLine("Sreda"); break;
                case 4: Console.WriteLine("Cetvrtak"); break;
                case 5: Console.WriteLine("Petak"); break;
                case 6: Console.WriteLine("Subota"); break;
                case 7: Console.WriteLine("Nedelja"); break;
                default: Console.WriteLine("Ima samo 7 dana"); break;
            }

        }

    }

}
