namespace Test
{
    class Compare
    {
        public static T Max<T>(T a, T b) where T: IComparable<T>
        {
            if(a.CompareTo(b) > 0){
                return a;
            }
            return b;
        }

        public static void Entry(){
            System.Console.WriteLine(Max(4, 5));
        }
    }
}