using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Program
    {
        static (int, int, int, string) Math(int [] x, string str)
        {
            int min = x[0];
            int max = x[0];
            int sum = x[0];
            string s = str.Substring(0, 1);

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max) max = x[i];
                if (x[i] < min) min = x[i];
                sum += x[i];
            }
            return (min,max,sum,s);
        }
        
        static void Main(string[] args)
        {
            
            //1
            /*a. Определите переменные всех возможных примитивных типов
                С# и проинициализируйте их.*/
            sbyte sb = 0;
            short sh = 1;
            int i = 2;
            long l = 3;
            byte by = 4;
            ushort us = 1;
            char[] ch = { 'a', 'b', 'c' };
            bool bo = true;
            float fl = 7;
            double dob = 1;
            decimal dec = 1;
            string str = "qqq";
            object ob = i;

            /*b. Выполните 5 операций явного и 5 неявного приведения.*/
            short sho = sb;
            int iny = sh;
            long loo = i;
            float ffl = l;
            double dbb = fl;

            int p = (int)dob;
            short dss = (short)fl;
            long gg = (long)dob;
            float we = (float)dec;
            sbyte ss = (sbyte)sh;

            /*c. Выполните упаковку и распаковку значимых типов.*/
            int x = 3;
            Object obj = x;
            byte m = (byte)(int)obj;

            /*d. Продемонстрируйте работу с неявно типизированной переменной.*/
            var mas = new[] { 2, 4.5 };
            var stirn = "sad";
            Console.WriteLine("   1.d");
            Console.Write(mas.GetType() + "\t" + stirn.GetType());

            /*e. Продемонстрируйте пример работы с Nullable переменной.*/
            int? x2 = null;
            int? x3 = null;
            Console.WriteLine("\n   1.e");
            Console.WriteLine(x2 == x3);


            //2
            /*a. Объявите строковые литералы. Сравните их.*/
            string a = "";
            string a1 = "qwe to dorn";
            string a2 = "qwe to dorn";
            string a3 = "asd net";
            Console.WriteLine("\n   2.a");
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1 == a3);

            /*b. Создайте три строки на основе String. Выполните: сцепление,
                копирование, выделение подстроки, разделение строки на слова,
                вставки подстроки в заданную позицию, удаление заданной
                подстроки.*/
            Console.WriteLine("\n   2.b");
            Console.WriteLine("Строки \n\t a1 = {0} \n\t a2 = {1} \n\t a3 = {2}", a1, a2, a3);

            //Сцепление
            a1 = String.Concat(a1, " ", a3);
            Console.WriteLine("Cцепление \n\t a1 = a1 + ' ' + a3 = {0} ", a1);

            //Копирование
            string a4 = String.Copy(a1);
            Console.WriteLine("Копирование \n\t a4 = a1 = {0} ", a4);

            //Выделение подстроки
            a = a1.Substring(0, 6);
            Console.WriteLine("Выделение подстроки \n\t a = a1(0,6) = {0} ", a);

            // Разделение строки на слова через Split
            string a22 = "qwe asd zxc rty fgh hjk";
            string[] words = a22.Split();
            Console.WriteLine("Разделение строки на слова через Split");
            foreach (var word in words)
            {
                Console.Write("-{0}-", word);
            }
            Console.WriteLine('\n');
           
            // Вставка строки в заданную позицию через Insert
            Console.WriteLine("Вставка строки в заданную позицию через Insert");
            string ma1 = a1.Insert(6, " Bongo");
            Console.WriteLine("\tBefore - {0}\n\tAfter - {1}", a1, ma1);

            //Yдаление заданной подстроки
            Console.WriteLine("Вставка строки в заданную позицию через Insert");
            string ma2 = ma1.Remove(6, 6);
            Console.WriteLine("\tBefore - {0}\n\tAfter - {1}", ma1, ma2);

            /*c. Создайте пустую и null строку. Продемонстрируйте что можно
                выполнить с такими строками*/
            //Работа с пустой и null строками
            Console.WriteLine("Работа с пустой и null строками");
            String nullstring = null;
            String emptyString = "";
            Console.WriteLine(emptyString.Length);
            //Console.WriteLine(nullstring.Length); //ошибка
            nullstring += emptyString;
            Console.WriteLine(nullstring.Length);
            Console.WriteLine(nullstring == emptyString);

            /*d. Создайте строку на основе StringBuilder. Удалите определенные
                позиции и добавьте новые символы в начало и конец строки.*/
            StringBuilder secd = new StringBuilder("Again new string");
            Console.Write("\n2.d\nСтрока\n\t {0}", secd);
            Console.Write("\nУдаление'new'\n\t {0}", secd, secd.Remove(6, 4));
            Console.Write("\nДобавление в начало\n\t {0}", secd, secd.Insert(0, "Clear "));
            Console.Write("\nДобавление в конец\n\t {0}\n", secd, secd.Append(" end"));


            //2 Массивы
            /*a. Создайте целый двумерный массив и выведите его на консоль в
                отформатированном виде (матрица).*/
            Console.WriteLine("2.a\nМатрица 3x3");
            int[][] matr = new int[3][];
            matr[0] = new int[3] { 1, 2, 3 };
            matr[1] = new int[3] { 4, 5, 6 };
            matr[2] = new int[3] { 7, 8, 9 };
            for (int k = 0; k < matr.Length; k++)
            {
                for (int c = 0; c < matr[k].Length; c++)
                {
                    Console.Write($"{matr[k][c]} \t");
                }
                Console.WriteLine();
            }
            /*b.Создайте одномерный массив строк. Выведите на консоль его
                содержимое, длину массива. Поменяйте произвольный элемент
                (пользователь определяет позицию и значение).*/
            string[] a8 = new string[] { "A", "B", "C" };
            string pos;
            Console.WriteLine("2.b\nДлина строкового массива - {0}", a8.Length);
            foreach (var word in a8)
            {
                Console.Write("-{0}-", word);
            }
            Console.WriteLine("\nВведите позицию элемента, который вы хотите изменить (от 0 до {0})-", a8.Length - 1);
            pos = Console.ReadLine();
            int pos1 = Convert.ToInt32(pos);

            Console.Write("Введите значение - ");
            a8[pos1] = Console.ReadLine();

            foreach (var word in a8)
            {
                Console.Write("-{0}-", word);
            }
            /*c. Создайте ступечатый (не выровненный) массив вещественных
                чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов
                соответственно. Значения массива введите с консоли.*/
            int[][] mass = new int[3][];
            mass[0] = new int[2] { 0, 0 };
            mass[1] = new int[3] { 0, 0, 0 };
            mass[2] = new int[4] { 0, 0, 0, 0 };
            Console.WriteLine("\n2.c\nВводите числа");
            for (int k = 0; k < mass.Length; k++)
            {
                for (int c = 0; c < mass[k].Length; c++)
                {
                    pos = Console.ReadLine();
                    mass[k][c] = Convert.ToInt32(pos);
                }
                Console.WriteLine();
            }
            for (int k = 0; k < mass.Length; k++)
            {
                for (int c = 0; c < mass[k].Length; c++)
                {
                    Console.Write($"{mass[k][c]} \t");
                }
                Console.WriteLine();
            }
            /*d. Создайте неявно типизированные переменные для хранения
                массива и строки.*/
            var mass2 = new[] { 1, 2, 3 };
            var strr2 =  "asdasd";


            //3 Кортежи
            /*a. Задайте кортеж из 5 элементов с типами int, string, char, string,
                ulong.*/
            //b. Сделайте именование его элементов.
            (int n, string ns, char nc, string ncs, ulong ul) kor = (5, "mb", 'd',  "mp",  9);

            /*c. Выведите кортеж на консоль целиком и выборочно (1, 3, 4
                элементы)*/
            Console.WriteLine("\n3.c\n\t" + kor);
            Console.WriteLine("\t "+ kor.n);
            Console.WriteLine("\t {0} {1} {2}",kor.ns , kor.nc , kor.ncs);
            Console.WriteLine("\t {0} {1} {2} {3}",kor.n , kor.ns , kor.nc , kor.ul);
           
            //d. Выполните распаковку кортежа в переменные.
            int n2 = kor.n;
            string ns2 = kor.ns;
            char nc2 = kor.nc;
            string ncs2 = kor.ncs;
            ulong ul2 = kor.ul;
            
            //e. Сравните два кортежа.
            (int, int) lb1 = (1, 1);
            (int, int) lb2 = (1, 1);
            Console.WriteLine("\n2.e");
            if (lb1.Item1 ==lb2.Item1 && lb1.Item2 == lb2.Item2)
            {
                Console.WriteLine("\tКортежи равны");
            }
            else
            {
                Console.WriteLine("\tКортежи не равны");
            }

            //5
            /*Создайте локальную функцию в main и вызовите ее. Формальные
                параметры функции – массив целых и строка. Функция должна вернуть
                кортеж, содержащий: максимальный и минимальный элементы массива,
                сумму элементов массива и первую букву строки.*/
            int[] massvp = new[] { 2, 1, 3 };
            string strvp = "ABC";
            (int, int, int, string) korvp = Math(massvp, strvp);
            Console.WriteLine("5\n"+korvp);
        }

    }
}