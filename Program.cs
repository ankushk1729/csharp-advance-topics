namespace Test
{
    class MainClass
    {
        
        public static void Main(){

            var ll = new LL<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Print();

            Delegate_.Entry();

            InbuiltDelegate.Entry();



            Compare.Entry();


            // Generic Pick utility
            var dict = new Dictionary<string, int>(){{"RollNo",0}, {"AccountNum", 45}};
            var newDict = Utility.Dict.Pick(dict, new List<string>(){"AccountNum"});

            foreach (KeyValuePair<string, int> item in newDict)
            {
                System.Console.WriteLine($"{item.Key}, {item.Value}");
            }


            // Events with custom delegate
            new EventWithCustomDelegate().Entry();

            // Events with inbuilt delegate
            new EventWithInbuiltDelegate().Entry();


            // Extension method
            int num = 4;
            num = num.Square();
            System.Console.WriteLine(num);

            // LINQ
            LINQ.Entry();

            // Dynamics
            Dynamic.Entry();

            // Exception
            Exception_.Entry();
            
            CustomException.Entry();

            // Async / Await
            Async.Entry();
        }
    }
}