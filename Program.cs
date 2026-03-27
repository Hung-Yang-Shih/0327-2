namespace _0327_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Manager m = new Manager();

            Console.WriteLine(m.GetStarup().ToString());

            //m.Startup = DateTime.UtcNow;

            Console.WriteLine(m.GetStarup().ToString());
        }
    }
}
