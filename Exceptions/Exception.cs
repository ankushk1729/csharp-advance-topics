namespace Test
{
    public class Exception_
    {
        public static void Entry(){
            try {
                int firstNum = 1;
                int secondNum = 0;
                int ans = firstNum / secondNum;
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}