namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                PopElement list = new PopElement();
                list.Insert(70);
                list.Insert(40);
                list.Insert(30);
                list.Insert(56);
                list.Pop();
                list.Print();

            
        }
    }
}