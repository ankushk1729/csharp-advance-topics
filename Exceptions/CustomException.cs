namespace Test
{
    public class APIException : Exception
    {
        public APIException(string message, Exception innerException) : base(message, innerException) {}
    }
    public class CustomException
    {
        public static void SomeOperation(){
            try {
                // Some API operations
                throw new Exception("Something went wrong!");
            }
            catch(Exception ex){
                throw new APIException("Unable to fetch data from api", ex);
            }
        }
        public static void Entry(){
            try {
                SomeOperation();
            }
            catch(Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}