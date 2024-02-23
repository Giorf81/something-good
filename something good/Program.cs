namespace something_good
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = Console.ReadLine();
            ChangeName(ref MyName);
        }


        static void ChangeName(ref string Name)
        {
            Console.WriteLine(Name);
        }
    }
}
