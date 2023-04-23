namespace LinkedListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
                SearchElement list = new SearchElement();
                list.Insert(70);
                //list.insert(40);
                list.Insert(30);
                list.Insert(56);
                list.Search(40);
                list.Print();
            
        }
    }
}