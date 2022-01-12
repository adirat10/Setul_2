using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_Setul_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();?
            //P17();
        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        /// Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, determinati
        /// nivelul maxim de incuibare a parantezelor.
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void P17()
        {
            int x, z = 0;
            bool ok = true;

            string line = Console.ReadLine();
            char[] sep = { ' ', ',', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int k = 0;
            while (k < t.Length)
            {
                x = int.Parse(t[k]);
                if (x == 0)
                    z++;
                else if (x == 1 && z == 0)
                    ok = false;
                else
                    z--;
                k++;
            }
            if (ok && z == 0)
                Console.WriteLine("Secventa reprezinta o secventa de paranteze corecta");
            else
                Console.WriteLine("Secventa NU reprezinta o secventa de paranteze corecta");
        }

        /// <summary>
        /// O secventa bitonica rotita este o secventa bitonica sau una ca poate fi transformata intr-o secventa
        /// bitonica prin rotiri succesive (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
        /// </summary>
        private static void P16()
        {
            int numar, n, k = 0;
            bool ok = true;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int anterior;
            anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < anterior)
                {
                    k++;
                }
                if (k == 1 || k == 3)
                {
                    if (numar > anterior)
                        ok = false;
                }
                anterior = numar;
            }
            if (ok && (k == 1 || k == 3))
                Console.WriteLine("Secventa data este o secventa bitonica rotita");
            else
                Console.WriteLine("Secventa data nu este o secventa bitonica rotita");
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
        /// </summary>
        private static void P15()
        {
            int numar, n, k = 0;
            bool ok = true;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int anterior;
            anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < anterior)
                    k = 1;
                if (k == 1)
                {
                    if (numar > anterior)
                        ok = false;
                }
                anterior = numar;
            }
            if (k == 1 && ok)
                Console.WriteLine("Secventa data este o secventa bitonica");
            else
                Console.WriteLine("Secventa data nu este o secventa bitonica");
        }

        /// <summary>
        /// O secventa monotona rotita este o secventa de numere monotona sau poate fi transformata intr-o secventa
        /// monotona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void P14()
        {
            int numar, n, k = 0, c = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int anterior;
            anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < anterior)
                    k++;
                else
                    c++;
                anterior = numar;
            }
            if (k <= 1 || c <= 1)
                Console.WriteLine("Secventa data este o secventa monotona rotita");
            else
                Console.WriteLine("Secventa data nu este o secventa monotona rotita");
        }

        /// <summary>
        /// O secventa crescatoare rotita este o secventa de numere care este in ordine crescatoare 
        /// sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive
        /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element
        /// devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
        /// </summary>
        private static void P13()
        {
            int numar, n, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int anterior;
            anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < anterior)
                    k++;
                anterior = numar;
            }
            if (k <= 1)
                Console.WriteLine("Secventa data este o secventa crescatoare rotita");
            else
                Console.WriteLine("Secventa data nu este o secventa cresacatoare rotita");
        }

        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
        /// Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        /// De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void P12()
        {
            int n, numar, anterior, k = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            anterior = int.Parse(t[0]);
            if (anterior != 0)
                k++;
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar != 0 && anterior == 0)
                    k++;
                anterior = numar;
            }
            Console.WriteLine($"Sunt {k} grupuri de numere consecutive diferite de zero in secventa data.");
        }

        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        private static void P11()
        {
            int n;
            double suma = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;
            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                suma = suma + ((double)(1 / numar));
            }
            Console.WriteLine($"Suma inverselor numerelor este {(double)suma}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        private static void P10()
        {
            int n, c = 1, maxc = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, nr_anterior;
            nr_anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == nr_anterior)
                {
                    c++;
                }
                else
                    c = 1;
                if (c > maxc)
                    maxc = c;
                nr_anterior = numar;
            }
            Console.WriteLine($"Numar maxim de numere consecutive egale este {maxc}");
        }

        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        private static void P9()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, nr_anterior;
            bool crescator = true;
            bool descrescator = true;
            nr_anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < nr_anterior)
                {
                    crescator = false;
                }
                if (numar > nr_anterior)
                {
                    descrescator = false;
                }
                nr_anterior = numar;
            }
            if (crescator || descrescator)
                Console.WriteLine("Secventa este monotona");
            else
                Console.WriteLine("Secventa nu este monotona");
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2).
        /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void P8()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            int f1 = 0, f2 = 1, f3;
            f3 = 1;
            for (int i = 4; i <= n; i++)
            {
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
            if (n == 1)
                Console.WriteLine($"Primul numar din sirul lui Fibonacci este 0");
            else if (n == 2)
                Console.WriteLine($"Al doilea numar din sirul lui Fibonacci este 1");
            else
                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {f3}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>
        private static void P7()
        {
            int n, numar, minim, maxim;
            minim = int.MaxValue;
            maxim = int.MinValue;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar > maxim)
                    maxim = numar;
                if (numar < minim)
                    minim = numar;
            }
            Console.WriteLine($"Cea mai mare valoare este {maxim}, iar cea mai mica valoare este {minim}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        /// </summary>
        private static void P6()
        {
            int n;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar, nr_anterior;
            bool ok = true;
            nr_anterior = int.Parse(t[0]);
            for (int i = 1; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar < nr_anterior)
                {
                    ok = false;
                    break;
                }
                nr_anterior = numar;
            }
            if (ok)
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");
        }
        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.
        /// Se considera ca primul element din secventa este pe pozitia 0.
        /// </summary>
        private static void P5()
        {
            int n, cate = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;
            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == i)
                    cate++;
            }
            if (cate == 1)
                Console.WriteLine($"Secventa contine un singur numar egal cu pozitia pe care se afla");
            else
                Console.WriteLine($"Secventa contine {cate} numere egale cu pozitia pe care se afla");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a.
        /// Se considera ca primul element din secventa este pe pozitia zero.
        /// Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>
        private static void P4()
        {
            int n, a, pozitie = -1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("a=");
            a = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);

            int numar;
            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar == a)
                    pozitie = i;
            }
            if (pozitie == -1)
                Console.WriteLine(-1);
            else
                Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitie}");

        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>
        private static void P3()
        {
            int n, suma = 0, produs = 1;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
                produs = produs * i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {suma}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este {produs}");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void P2()
        {
            int n, negative = 0, zero = 0, pozitive = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int numar;
            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar > 0)
                    pozitive++;
                else if (numar < 0) negative++;
                else zero++;
            }
            Console.WriteLine($"Secventa contine {pozitive} numere pozitive, {negative} numere negative si {zero} de zero");
        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare
        /// </summary>
        private static void P1()
        {
            int n, cate = 0;
            Console.Write("n=");
            n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] sep = { ' ', '\n', '\t', '\r' };
            string[] t = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int numar;
            for (int i = 0; i < n; i++)
            {
                numar = int.Parse(t[i]);
                if (numar % 2 == 0)
                    cate++;
            }
            Console.WriteLine($"Secventa contine {cate} numere pare");
        }
    }
}
