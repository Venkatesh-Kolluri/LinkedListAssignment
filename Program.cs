namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

                DeleteElement list = new DeleteElement();
                list.Insert(70);
                list.Insert(40);
                list.Insert(30);
                list.Insert(56);
                list.Remove(40);
                list.Print();
        }
    }
}