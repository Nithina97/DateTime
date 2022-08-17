// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
    class Program{
        static void Main(string[] args)
        {
            DateTime d=DateTime.Now;
           
           
            Console.WriteLine(d.DayOfWeek);   
            Console.WriteLine(d.ToString("MMMM"));
           

            Console.ReadLine();
        }
        
    }

