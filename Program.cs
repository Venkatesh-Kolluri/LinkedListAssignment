namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PopFirstElement list = new PopFirstElement();
            list.Insert(70);
            list.Insert(40);
            list.Insert(30);
            list.Insert(56);
            list.PopFirst();
            list.PopFirst();
            list.PopFirst();
            list.Print();

        }
    }
}