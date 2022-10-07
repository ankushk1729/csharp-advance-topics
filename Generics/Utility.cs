namespace Test
{
    public class Utility
    {
        public class Dict {
            public static Dictionary<T, U> Pick<T, U>(Dictionary<T, U> originalDict, List<T> list)
            {
                var dict = new Dictionary<T, U>();
                
                foreach(KeyValuePair<T, U> kv in originalDict){
                    if(list.Contains(kv.Key)){
                        dict.Add(kv.Key, kv.Value);
                    }
                }
                return dict;
            }
        }
    }
}