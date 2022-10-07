namespace Test
{
    class Node<T>
    {
        public T Data {get; set;}
        public Node<T>? next;


        public Node(){
            next = null;
        }
    }
}