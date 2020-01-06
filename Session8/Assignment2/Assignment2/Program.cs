using System;

//namespace Assignment2
//{
//class Program
//{
//static void Main(string[] args)
//{
//    int[] X = new int[10] { 0, 1, 4, 9, 16, 0, 0, 0, 0, 0 };
//    int k;
//    for (k = 5; k < 10; ++k) { X[k] = k * k; }
//    for (k = 0; k < X.Length; k++) { Console.Write("{0}    ", X[k]); }
//}

//// factorial
//public static void Main()
//{
//    long nFactorial = 1;
//    long nComputeTo = 5;
//    long nCurDigit = 1;
//    try
//    {
//        long x = 1 / (1 - nFactorial);
//        checked
//        { 
//            for (; nCurDigit <= nComputeTo; nCurDigit++) 
//            { 
//                nFactorial *= nCurDigit; 
//            } 
//        }
//    }
//    catch (OverflowException e)
//    {
//        Console.WriteLine("Computing {0}! caused an overflow {1}", nComputeTo, e.StackTrace); return;
//    }
//    Console.WriteLine("{0}! is {1}", nComputeTo, nFactorial);
//}
//}
//}

//class Shape { }
//class Test
//{
//    static void Main()
//    {
//        Shape s = new Shape();
//        Console.WriteLine(s);
//    }
//}

//class Test
//{
//    static void Main()
//    {
//        int[] xlist = new int[] { 9, 5, 3, -2, 4, 5 }; 
//        for (int x = 0; x < xlist.Length; x++) 
//        { 
//            if (xlist[x] == 3) 
//            { 
//                for (int y = x; y < xlist.Length - 1; y++) 
//                { 
//                    xlist[y] = xlist[y + 1]; 
//                } 
//            } 
//        }
//        foreach (int v in xlist)
//        { 
//            Console.Write("{0} ", v); 
//        }
//    }
//}

class Test { static void Main() { int[] xlist = new int[] { 7, -2 }; for (int x = 0; x < xlist.Length - 1; x++) { if (xlist[x] > xlist[x + 1]) { int t = xlist[x]; xlist[x] = xlist[x + 1]; xlist[x + 1] = t; } } foreach (int v in xlist) { Console.Write("{0} ", v); } } }