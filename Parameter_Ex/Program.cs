using System;

namespace Parameter_Ex
{
    class Program
    {
        // 예제 Struct
        struct Numbers
        {
            public int a;
            public int b;
            public int c;
            public int d;
            public int e;
        }
        static void Main(string[] args)
        {
            // pass by value
            int i = 1;     
            // pass by reference. ref : Read Write
            int r = 2;
            //  pass by reference. out : Write. (이 곳에서 값을 할당 하더라도 사용 불가능 함. 즉, 출력만 가능.)
            int o;
            // pass by reference. in : Read Only
            int ro = 3;

            // 예제용
            Numbers n = new Numbers();
            n.a = 1;
            n.b = 2;
            n.c = 3;
            n.d = 4;
            n.e = 5;

            Console.WriteLine("********************");
            Run1(i);
            // 1 출력
            Console.WriteLine(i);

            Console.WriteLine("********** ref **********");
            Run2(i, ref r);
            // 102 출력
            Console.WriteLine(r);
            
            Console.WriteLine("********** out **********");
            Run3(i, ref r, out o);
            // 102 출력
            Console.WriteLine(r);
            // 100 출력
            Console.WriteLine(o);     

            Console.WriteLine("********** in (Read Only) **********");
            Run4(i, ref r, out o, in ro);
            Console.WriteLine();

            Console.WriteLine("********** 예제 **********");
            Run5(i, ref r, out o, in ro, in n);
        }
        
        static void Run1(int i)
        {
            i += 100;
            Console.WriteLine(i);               // 101
        }
        
        static void Run2(int i, ref int r)
        {
            r += 100;
            // 102 출력
            Console.WriteLine(r);
        }        
        
        static void Run3(int i, ref int r, out int o)
        {
            r += 100;
            o = 100;
        }        
        
        static void Run4(int i, ref int r, out int o, in int ro)
        {
            r += 100 + ro;
            o = 100;
            //ro = 20;          할당 불가. Read Only임
        }        
        
        static void Run5(int i, ref int r, out int o, in int ro, in Numbers num)
        {
            r += 100 + ro;
            o = 100;
            int sum = num.a + num.b;
            Console.WriteLine(sum);
        }
    }
}
