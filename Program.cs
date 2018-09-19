using System;
 
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool: хранит значение true или false 
            bool isDead = true;

            //byte: хранит целое число от 0 до 255 и занимает 1 байт
            byte bit1 = 102;
            
            //sbyte: хранит целое число от -128 до 127 и занимает 1 байт
            sbyte bit2 = -101;

            //short: хранит целое число от -32768 до 32767 и занимает 2 байта
            short n1 = 102;

            //ushort: хранит целое число от 0 до 65535 и занимает 2 байта
            ushort n2 = 102;

            //int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            int a1 = 10;
            int b1 = 0b101;  // бинарная форма b =5
            int c1 = 0xFF;   // шестнадцатеричная форма c = 255

            //uint: хранит целое число от 0 до 4294967295 и занимает 4 байта
            uint a2 = 10;
            uint b2 = 0b101;
            uint c2 = 0xFF;

            //long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            long a3 = -10;
            //long b = 0b101;
            //long c = 0xFF;

            //ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            ulong a4 = 10;

            //float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта
            float f=3.14f;

            //double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта
            double d=3.14;

            //decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой,
            //имеет значение от 0 до +/–79 228 162 514 264 337 593 543 950 335; если с запятой,
            // то от 0 до +/–7,9228162514264337593543950335 с 28 разрядами после запятой и занимает 16 байт
            decimal dec=3.14m;

            //char: хранит одиночный символ в кодировке Unicode и занимает 2 байта.
            //Этому типу соответствуют символьные литералы
            char ch1 = 'A';
            char ch2 = '\x5A';
            char ch3 = '\u0420';

            //string: хранит набор символов Unicode.
            string HelloWorld = "Hello World";

            //object: может хранить значение любого типа данных и занимает 4 байта на
            //32-разрядной платформе и 8 байт на 64-разрядной платформе.
            object obj1 = 22;
            object obj2 = 3.14;
            object obj3 = "hello code";

            Console.WriteLine($"bool: Is Dead?: {isDead}");
            Console.WriteLine($"byte: {bit1}");
            Console.WriteLine($"sbyte: {bit2}");
            Console.WriteLine($"short: {n1}");
            Console.WriteLine($"ushort: {n2}");
            Console.WriteLine($"int: {a1}");
            Console.WriteLine($"int bin: {b1}");
            Console.WriteLine($"int 16: {c1}");
            Console.WriteLine($"uint: {a2}");
            Console.WriteLine($"uint bin: {b2}");
            Console.WriteLine($"uint 16: {c2}");
            Console.WriteLine($"long: {a3}");
            Console.WriteLine($"ulong: {a4}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"char1: {ch1}");
            Console.WriteLine($"char2: {ch2}");
            Console.WriteLine($"char3: {ch3}");
            Console.WriteLine($"string: {HelloWorld}");
            Console.WriteLine($"object int: {obj1}");
            Console.WriteLine($"object float: {obj2}");
            Console.WriteLine($"object string: {obj3}");

        }
    }
}