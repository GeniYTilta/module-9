using System;

namespace module_9
{
    class Program
    {
        public delegate int DifferenceDelegate(int a, int b);
        delegate void MultiDelegate(int a, int b);
        delegate void ShowMessageDelegate(string _message);
        delegate int RandomDelegate();
       
        static void Main(string[] args)
        {

            ShowMessageDelegate sm = delegate (string _message)
            {
                Console.WriteLine(_message);
            };

            sm.Invoke("HW!");

            RandomDelegate rd = delegate ()
            {
                return new Random().Next(0, 100);
            };

            int result = rd.Invoke();
            Console.WriteLine(result);

            ShowMessageDelegate dm =  (string _message) =>
            {
                Console.WriteLine(_message);
            };
            dm.Invoke("HW2!");

            RandomDelegate Rd =  () =>
            {
                return new Random().Next(0, 100);
            };

            int result2 = rd.Invoke();
            Console.WriteLine(result2);

            Console.ReadKey();



            /*DifferenceDelegate differenceDelegate = difference;
            int f = differenceDelegate(15, 2);
            int c = differenceDelegate.Invoke(10, 5);
            Console.WriteLine(c);
            Console.WriteLine(f);


            MultiDelegate multicastdelegate = diff;
            multicastdelegate += sum;
            multicastdelegate.Invoke(20, 15);
            multicastdelegate -= sum;
            multicastdelegate.Invoke(10, 7);

            Action showMessageDelegate = ShowMessage;
            showMessageDelegate.Invoke();

            Func<int, int, int, int> sumDelegate = Sum2;
            int result = sumDelegate.Invoke(1, 30, 120);
            Console.WriteLine(result);

            Predicate<string> checkLengthDelegate = CheckLength;
            bool status = checkLengthDelegate.Invoke("skill_factory");
            Console.WriteLine(status);

            Console.ReadLine();

            Console.ReadKey();

        }*/

        static int difference(int a, int b)
            {
                return a - b;

            }

            static void diff(int a, int b)
            {
                Console.WriteLine(b - a);
            }

            static void sum(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            static void ShowMessage()
            {
                Console.WriteLine("Hello World!");
            }

            static int Sum2(int a, int b, int c)
            {
                return a + b + c;
            }

            static bool CheckLength(string message)
            {
                if (message.Length > 3) return true;
                return false;
            }
            static void ShowMessage1(string _message)
            {
                Console.WriteLine(_message);
            }

            static int RandomNumber()
            {
                return new Random().Next(0, 100);
            }
        }
    } 
}
