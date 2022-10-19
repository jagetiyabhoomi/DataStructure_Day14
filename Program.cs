namespace DataStructureDay14
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("element added!!");
            //Console.WriteLine("Queue Front : {0}",queue.front.key);
            //Console.WriteLine("Queue Rear : {0}", queue.rear.key);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine("Elements removed!!");


        }
    }
}
