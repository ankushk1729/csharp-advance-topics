namespace Test
{
    public class LL<T>
     {
        private Node<T>? head;
        public LL(){
            head = null;
        }   

        public void Add(T item){
            if(head == null){
                head = new Node<T>() {Data = item};
                return;
            }
            var newNode = new Node<T>() {Data = item};
            Node<T> temp = head;
            while(temp.next != null){
                temp = temp.next;
            }
            temp.next = newNode;
        }

        public void Print(){
            Node<T>? temp = head;
            while(temp!.next != null){
                Console.WriteLine($"{temp.Data}");
                temp = temp.next;
            }
        }
    } 
}