namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                InsertBetween list = new InsertBetween();
                list.Insert(70);
                //list.insert(40);
                list.Insert(30);
                list.Insert(56);
                list.Print();
                list.InBetween(40, 30);
                list.Print();
            }


        }
    }
}