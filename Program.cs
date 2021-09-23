using System;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAalive = true;
            byte bit = 1;
            sbyte bit1 = -1;
            short n1 = -1;
            ushort n2 = 1;
            int i = 10;
            uint ui = 1111111111;
            long l = -111111111;
            ulong ul = 1111111;
            float f = 1.25f;
            double d = 1.25;
            decimal dc = 1.22222222222m;
            char a = 'a';
            string str = "Hello";
            object obj = 123;

            isAalive = 1 == Convert.ToInt32(Console.ReadLine());
            bit = Convert.ToByte(Console.ReadLine());
            bit1 = Convert.ToSByte(Console.ReadLine());
            n1 = Convert.ToInt16(Console.ReadLine());
            n2 = Convert.ToUInt16(Console.ReadLine());
            i = Convert.ToInt32(Console.ReadLine());
            ui = Convert.ToUInt32(Console.ReadLine());
            l = Convert.ToInt64(Console.ReadLine());
            ul = Convert.ToUInt64(Console.ReadLine());
            f = Convert.ToSingle(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            dc = Convert.ToDecimal(Console.ReadLine());
            a = Convert.ToChar(Console.ReadLine());
            str = Console.ReadLine();
            obj = Console.ReadLine();

            Console.WriteLine("\nbool {0}\nbyte {1}\nsbyte {2}\nshort {3}" +
                "\nushort {4}\nint {5}\nuint {6}\n" +
                "long {7}\nulong {8}\nfloat {9}\ndouble {10}\ndecimal {11}" +
                "\nchar {12}\nstring {13}\nobject {14}\n",
                isAalive.ToString(), bit, bit1, n1, n2, i, ui, l, ul, f, d, dc, a, str, obj);
            
            long c1 = i;
            float h1 = ul;
            decimal d1 = l;
            uint e1 = bit;
            long a1 = bit1;
            long c2 = (long)i;
            float h2 = (float)ul;
            decimal d2 = (decimal)l;
            uint e2 = (uint)bit;
            long a2 = (long)bit1;
            
            object obj1 = l;
            long l1 = (long)obj1;
            
            var var1 = 123;
            
            int? i1 = 5;
            i1 = null;
            
            var var2 = 1;
            //var2 = 1.25f;

            string ab = "Hello";
            string ab1 = "world";
            Console.WriteLine("Comparising strings " + ab.Equals(ab1));
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            string ab8 = "hello";
            string ab9 = "world";
            string ab2 = "123";
            string ab3 = ab8 + " " + ab9 + " " + ab2;
            string ab4 = String.Copy(ab8);
            string ab5 = ab9.Substring(3, 2);
            string text = "И поэтому все так произошло";
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s1 in words)
            {
                Console.WriteLine(s1);
            }
            string text1 = "Хороший день";
            string subString = "замечательный ";

            text1 = text1.Insert(8, subString);
            Console.WriteLine(text1);
            text1 = text1.Remove(0, 3);
            Console.WriteLine("Remove strings: ", text1);
            Console.WriteLine("Concat: {0}\n Copy: {1}\n Substring: {2}\n ", ab3, ab4, ab5);
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            string str1 = "";
            string str2 = null;
            string str3 = "123";
            Console.WriteLine("Является ли строка str1 пустой: ");
            Console.WriteLine(str1 == ""); // True
            Console.WriteLine("Является ли строка str1 StringEmpty: ");
            Console.WriteLine(str1 == string.Empty); // True
            Console.WriteLine("Является ли длина пустой строки str1=0: ");
            Console.WriteLine(str1.Length == 0); // True
            Console.WriteLine("Присвоим пустой строке значение 123: ");
            str1 = str3;
            Console.WriteLine(str1);
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            Console.WriteLine("Относится ли строка str2 к типу null? : ");
            Console.WriteLine(string.IsNullOrEmpty(str2)); // True
            Console.WriteLine("Является ли строка str2 пустой: ");
            Console.WriteLine(str2 == ""); // False
            Console.WriteLine("Присвоим строке-null значение 123: ");
            str2 = str3;
            Console.WriteLine(str2);
            Console.WriteLine("Является ли длина пустой строки str1=0: ");
            Console.WriteLine(str2.Length == 0); // NullReferenceException
            Console.ReadLine();
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            StringBuilder sb1 = new StringBuilder("ABC", 50);
            Console.WriteLine("Строка sb1 : {0}", sb1);
            sb1.Append(new char[] { 'D', 'E', 'F' });//добавление в конец
            Console.WriteLine("Добавили 3 символа в конец : {0}", sb1);
            sb1.AppendFormat("GYI {0}{1}", 'J', 'K');
            Console.WriteLine("Выводим длину строки и саму строку:");
            Console.WriteLine("{0} chars: {1}", sb1.Length, sb1.ToString());
            sb1.Insert(0, "Alphabet ");
            Console.WriteLine("Добавили Alphabet в начало : {0}", sb1);
            sb1.Remove(0, 8);
            Console.WriteLine("Удаляем слово alphabet начиная с 0 позиции:{0}", sb1);
            // получаем строку из объекта StringBuilder
            string st1 = sb1.ToString();
            Console.WriteLine("Преобразование в строку :{0}", sb1);
            Console.WriteLine("---------------------------------");
            
            int[,] massiv = new int[,] { { 1, 2, 3, 4 }, { 4, 3, 2, 1 } };
            for (int j = 0; j < massiv.GetLength(0); j++)
            {
                for (int k = 0; k < massiv.GetLength(1); k++)
                {
                    Console.Write("\t" + massiv[j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            
            string[] strmas = { "hello", "world", "C#", "POIBMS" };
            for ( i = 0; i < strmas.GetLength(0); i++)
                Console.Write("\t" + strmas[i] + "\t");
            Console.WriteLine();
            Console.WriteLine("length= " + strmas.GetLength(0) + "\n Element number");
            int numb = Convert.ToInt32(Console.ReadLine());
            string repl = Console.ReadLine();
            strmas[numb] = repl;
            for ( i = 0; i < strmas.GetLength(0); i++)
                Console.Write("\t" + strmas[i] + "\t");
            Console.WriteLine();
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            
            int[][] mass = new int[3][];
            mass[0] = new int[2] { 0, 0 };
            mass[1] = new int[3] { 0, 0, 0 };
            mass[2] = new int[4] { 0, 0, 0, 0 };
            Console.WriteLine("\n2.c\nВводите числа");
            for ( i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                    mass[i][j] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            for ( i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass[i].Length; j++)
                    Console.Write($"{mass[i][j]}\t");
                Console.WriteLine();
            }
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            
            var nemas = new[] { 1, 2, 3, 4 };
            var nestr = "String";

            (int, string, char, string, ulong) tuple = ( 10, "Hello", '4', "world", 111);

            Console.WriteLine(tuple);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(tuple.Item1 + "\t" + tuple.Item3 + "\t" + tuple.Item4);
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            
            (var one, var two, var thre, var four, var five) = tuple;
            
            (int, string, char, string, ulong) tuple2 = (15, "Hello", '4', "World", 111);
            Console.WriteLine(tuple == tuple2);
            Console.WriteLine("---------------------------------");
            Console.ReadLine();

            int[] mask = new int[] { -22, 2, 1, 50, 47 };
            string str4 = "Stroka";
            LocFunc(mask, str4);
            void LocFunc(int[] kmas, string str22)
            {
                (int, int, int, string) tuple3;
                int min = 100;
                int max = -100;
                int summ = 0;
                for ( i = 0; i < kmas.GetLength(0); i++)
                {
                    if (kmas[i] > max)
                        max = kmas[i];
                    if (kmas[i] < min)
                        min = kmas[i];
                    summ = summ + kmas[i];
                }
                string firstLetter = str22.Substring(0, 1);
                tuple3 = (max, min, summ, firstLetter);
                Console.WriteLine(tuple3);
                return;
            }
            Console.WriteLine("---------------------------------");
            Console.ReadKey();

            LocFunc2();
            LocFunc3();

            void LocFunc2()
            {
                try
                {
                    checked
                    {
                        int i2 = int.MaxValue;
                    }
                }
                catch
                {

                }
            }

            void LocFunc3()
            {
                try
                {
                    unchecked
                    {
                        int i3 = int.MaxValue;
                    }
                }
                catch
                {

                }
            }
            Console.WriteLine("---------------------------------");
            Console.ReadKey();
        }
    }
}
