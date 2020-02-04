using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task1_Mia_Huljanah
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberOne.Anagram();
            //NumberTwo.ArrSort();
            //NumberTwo.ArrReverse();
            //NumberTwo.ArrSplice();
            //NumberThree.CaesarCipher();
            //NumberFour.FizzBuzz();
            //NumberFive.Arr();
            //NumberSix.maxChar();
            //NumberSeven.Palindrom();

            //Console.WriteLine("Masukkan angka yang anda inginkan :");
            //int k = Convert.ToInt32(Console.ReadLine());
            //int a = NumberEight.factorial(k);
            //Console.WriteLine(a);

            //NumberNine.BubbleSort();
            //NumberNine.InsertionSort();
            //NumberNine.SelectSort();

            //NumberTen.Capitalization();
            //NumberEleven.stringReversal();

        }
    }

//    class NumberOne
//    {
//        public static void Anagram()
//        {
//        Console.WriteLine("Masukkan String Pertama : ");
//        string str1 = Console.ReadLine();
//        Console.WriteLine("Masukkan String Kedua : ");
//        string str2 = Console.ReadLine();
//        char[] ch1 = str1.ToLower().ToCharArray();
//        char[] ch2 = str2.ToLower().ToCharArray();
//        Array.Sort(ch1);
//        Array.Sort(ch2);
//        string v1 = new string(ch1);
//        string v2 = new string(ch2);

//        Console.WriteLine(value: v1 == v2);
//        }
//    }

//    class NumberTwo
//    {
//        public static void ArrSort()
//        {
//            Console.Write("Masukkan 5 angka yang kamu inginkan satu per satu: ");
//            string[] data = new string[5];
//            for (int i = 0; i < data.Length; i++)
//            {
//                data[i] = Console.ReadLine();
//            }
//            Array.Sort(data);
//            Console.WriteLine("Sort dari angka yang kamu input adalah : ");
//            foreach (var i in data)
//            {
//                Console.Write(i + " ");
//            }
//            Console.WriteLine(" ");
//        }

//        public static void ArrReverse()
//        {
//            Console.Write("Masukkan 5 angka yang kamu inginkan satu per satu: ");
//            string[] data = new string[5];
//            for (int i = 0; i < data.Length; i++)
//            {
//                data[i] = Console.ReadLine();
//            }
//            Array.Reverse(data);
//            Console.WriteLine("Reverse dari angka yang kamu input adalah : ");
//            foreach (var j in data)
//            {
//                Console.Write(j + " ");
//            }
//        }

//        public static void ArrSplice()
//        {
//            Console.Write("Masukkan 5 angka yang kamu inginkan satu per satu: ");
//            string[] data = new string[5];
//            for (int i = 0; i < data.Length; i++)
//            {
//                data[i] = Console.ReadLine();
//            }
//            for (int i = 0; i < data.Length; i++)
//            {
//                Console.Write(data[i] + " ");
//            }
//            Console.WriteLine("Masukkan angka yang ingin kamu input : ");
//            string angka = Console.ReadLine();
//            Console.WriteLine("Masukkan index dari angka tersebut : ");
//            int index = Convert.ToInt32(Console.ReadLine());
//            string[] newArr = new string[data.Length + 1];
//            for (int i = 0; i < data.Length + 1; i++)
//            {
//                if (i < index)
//                {
//                    newArr[i] = data[i];
//                }
//                else if (i == index)
//                {
//                    newArr[i] = angka;
//                }
//                else
//                {
//                    newArr[i] = data[i - 1];
//                }
//            }
//            for (int i = 0; i < data.Length; i++)
//            {
//                Console.Write(newArr[i] + " ");
//            }

//        }

//    }

//    class NumberThree
//    {
//        public static void CaesarCipher()
//        {
//            Console.WriteLine("Masukkan kata yang anda inginkan tanpa karakter;");
//            string str1 = Console.ReadLine();
//            Console.WriteLine("Masukkan angka yang kamu inginkan :");
//            int shift = Convert.ToInt32(Console.ReadLine());
//            char[] ch = str1.ToCharArray();
//            for (int i = 0; i < ch.Length; i++)
//            {
//                char letter = ch[i];
//                letter = (char)(letter + shift);
//                if (letter > 'z')
//                {
//                    letter = (char)(letter - 26);
//                }
//                else if (letter < 'a')
//                {
//                    letter = (char)(letter + 26);
//                }
//                ch[i] = letter;
//            }
//            string rev = new string(ch);
//            Console.WriteLine(rev);


//        }

//    }

//    class NumberFour
//    {
//        public static void FizzBuzz()
//        {
//            Console.WriteLine("Masukkan angka yang kamu inginkan : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            string a = "";
//            if (n % 2 == 0 && n % 3 == 0)
//            {
//                a = "Fizz Buzz";
//            }
//            else if (n % 3 == 0)
//            {
//                a = "Buzz";
//            }
//            else if (n % 2 == 0)
//            {
//                a = " Fizz";
//            }
//            Console.WriteLine(a);
//        }

//    }

//class NumberFive
//{
//    public static void Arr()
//    {
//        Console.Write("Masukkan 5 angka yang kamu inginkan satu per satu: ");
//        int[] data = new int[5];
//        for (int i = 0; i < data.Length; i++)
//        {
//            data[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int index3 = Array.IndexOf(data, 3);
//        Console.WriteLine($"index 3 from data is: {index3}");

//        int lastIndex = data.Length - 1;
//        Console.WriteLine($"Last index from data is : {lastIndex}");

//        bool a = Array.Exists(data, element => element == 6);
//        Console.WriteLine($" data includes 6 is {a}");

//        bool b = Array.Exists(data, element => element == 5);
//        Console.WriteLine($" data includes 5 is {b}");

//        int c = data.Sum();
//        Console.WriteLine($"Sum from data is : {c}");

//        Console.WriteLine(String.Join("-", data));

//        //Console.WriteLine(Array.Fill(data, 3, 0, 5));
//        for (int i = 0; i < data.Length; i++)
//        {
//            if (data[i] != 3)
//            {
//                data[i] = 3;
//            }
//        }
//        foreach (var j in data)
//        {
//            Console.Write(j + " ");
//            }
//        }
//    }

//        class NumberSix
//{
//    public static void maxChar()
//    {
//        Console.WriteLine("Masukkan kata yang kamu inginkan :");
//        string str = Console.ReadLine();
//        var str1 = str.ToCharArray();
//        var a = -1;
//        var b = ' ';
//        foreach (var i in str1)
//        {
//            int c = 0;
//            foreach (var j in str1)
//            {
//                if (i == j)
//                {
//                    c++;
//                }
//            }
//            if (a<c)
//                {
//                    a = c;
//                    b = i;
//                }
//            }
//            Console.WriteLine(b);
//        }
//    }

//        class NumberSeven
//{
//    public static void Palindrom()
//    {
//        Console.WriteLine("Masukkan kata yang anda inginkan;");
//        string str1 = Console.ReadLine();
//        string str2 = Regex.Replace(str1, @"[a-zA-Z]+", "");
//        char[] ch = str2.ToCharArray();
//        Array.Reverse(ch);
//        string rev = new string(ch);

//        bool y = str2.Equals(rev, StringComparison.OrdinalIgnoreCase);
//        Console.WriteLine(y);
//    }
//}

//class NumberEight
//    {
//        public static int factorial(int k)
//        {

//            int a = 0;
//            if (k == 1)
//            {
//                a = 1;
//            }
//            else
//            {
//                a = k * factorial(k - 1);
//            }
//            return a;
//        }
//    }

//    class NumberNine
//    {
//        public static void BubbleSort()
//    {
//        int[] arr = { 5, 4, 3, 2, 1 };
//        int temp;
//        for (int j = 0; j <= arr.Length - 2; j++)
//        {
//            for (int i = 0; i <= arr.Length - 2; i++)
//            {
//                if (arr[i] > arr[i + 1])
//                {
//                    temp = arr[i + 1];
//                    arr[i + 1] = arr[i];
//                    arr[i] = temp;
//                }
//            }
//        }
//        Console.WriteLine("Sorted:");
//        foreach (int p in arr)
//            Console.Write(p + " ");
//        Console.Read();
//    }

//    public static void InsertionSort()
//    {
//        int[] arr = new int[5] { 5, 4, 3, 2, 1 };
//        int n = 5, i, j, val, flag;
//        Console.WriteLine("Insertion Sort");
//        Console.Write("Initial array is: ");
//        for (i = 0; i < n; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        for (i = 1; i < n; i++)
//        {
//            val = arr[i];
//            flag = 0;
//            for (j = i - 1; j >= 0 && flag != 1;)
//            {
//                if (val < arr[j])
//                {
//                    arr[j + 1] = arr[j];
//                    j--;
//                    arr[j + 1] = val;
//                }
//                else flag = 1;
//            }
//        }
//        Console.Write("\nSorted Array is: ");
//        for (i = 0; i < n; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }

//        public static void SelectSort()
//    {
//        int[] arr = new int[5] { 5, 4, 3, 2, 1 };
//        int n = 5;
//        Console.WriteLine("Selection sort");
//        Console.Write("Initial array is: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//        int temp, smallest;
//        for (int i = 0; i < n - 1; i++)
//        {
//            smallest = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if (arr[j] < arr[smallest])
//                {
//                    smallest = j;
//                }
//            }
//            temp = arr[smallest];
//            arr[smallest] = arr[i];
//            arr[i] = temp;
//        }
//        Console.WriteLine();
//        Console.Write("Sorted array is: ");
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(arr[i] + " ");
//        }
//    }

//    class NumberTen
//        {
//            public static void Capitalization()
//            {
//                Console.WriteLine("Masukkan kata yang anda inginkan;");
//                string str1 = Console.ReadLine();
//                char[] ch = str1.ToCharArray();
//                if (ch.Length >= 1)
//                {
//                    if (char.IsLower(ch[0]))
//                    {
//                        ch[0] = char.ToUpper(ch[0]);
//                    }
//                }
//                for (int i = 1; i < ch.Length - 1; i++)
//                {
//                    if (ch[i - 1] == ' ')
//                    {
//                        if (char.IsLower(ch[i]))
//                        {
//                            ch[i] = char.ToUpper(ch[i]);
//                        }
//                    }
//                }
//                string rev = new string(ch);
//                Console.WriteLine(rev);
//            }
//        }

//        class NumberEleven
//        {
//        public static void stringReversal()
//        {
//            Console.WriteLine("Masukkan kata yang anda inginkan;");
//            string str1 = Console.ReadLine();
//            char[] ch = str1.ToCharArray();
//            Array.Reverse(ch);
//            string rev = new string(ch);
//            Console.WriteLine(rev);
//        }

//    }
//}
}