// Action for functions that doesn't return a value
// Func for functions that return a value

namespace Test
{
    class InbuiltDelegate
    {
        public static void Entry(){
            Action<string> pd = print;
            Action<string> pdWithGreeting = printWithGreeting;
            
            // Single Delegate 
            pd("Hello");
            MethodWithCallback("Yo", pd);

            // MultiCast Delegate
            pdWithGreeting("Nice");
            printDelegate pdCombined = print;
            pdCombined += printWithGreeting;

            pdCombined("nice nice");


            Func<int, int, int> adder = Add;

            // Assigning lambda expression to delegate
            Func<int, int, int> multiplier = (num1, num2) => num1* num2;

            System.Console.WriteLine( adder(4, 5));

            System.Console.WriteLine(multiplier(6, 7));
        }

        public static int Add(int a, int b){
            return a + b;
        }
        public static void print(string message){
            Console.WriteLine(message);
        }
        public static void printWithGreeting(string message){
            Console.WriteLine($"Hello your messsage is : {message}");
        }
        public static void MethodWithCallback(string message, Action<string> callback){
            callback(message);
        }
        public delegate void printDelegate(string message);
    }
}