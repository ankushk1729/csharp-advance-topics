namespace Test
{
    public class Async
    {

        // Async function which doesn't return (i.e returns void)
        public static async Task SomeOperationAsync(){
            System.Console.WriteLine("Something without returning!!!!!");
        }

        // Async function which returns something
        public static async Task<string> SomeOperationWithReturnAsync(){
            System.Console.WriteLine("Something with returning!!!!!");
            return "Done doing something";
        }

        public static async void Entry(){
            System.Console.WriteLine("This should be printed first");
            await SomeOperationAsync();

            var result = await SomeOperationWithReturnAsync();

            System.Console.WriteLine(result);


            // Await for all or any (Just like Promise.all and Promise.any in JavaScript)
            var operations = new List<Task>();
            operations.Add(SomeOperationAsync());
            operations.Add(SomeOperationWithReturnAsync());

            await Task.WhenAny(operations);
            System.Console.WriteLine("Atleast one operation finished");

            await Task.WhenAll(operations);
            System.Console.WriteLine("All operations finished");


        }

    }
}