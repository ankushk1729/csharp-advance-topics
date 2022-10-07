// Delegate kind of store a function reference with its signature
namespace Test
{
    class Delegate_
    {
        public static void Entry(){
            printDelegate pd = print;
            printDelegate pdWithGreeting = printWithGreeting;

            // Single Delegate 
            pd("Hello");
            MethodWithCallback("Yo", pd);

            // MultiCast Delegate
            pdWithGreeting("Nice");
            printDelegate pdCombined = print;
            pdCombined += printWithGreeting;

            pdCombined("nice nice");

        }
        public static void print(string message){
            Console.WriteLine(message);
        }
        public static void printWithGreeting(string message){
            Console.WriteLine($"Hello your messsage is : {message}");
        }
        public static void MethodWithCallback(string message, printDelegate callback){
            callback(message);
        }
        public delegate void printDelegate(string message);

    }
}