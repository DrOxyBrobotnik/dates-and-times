namespace dates_and_times
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.ReadLine();
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1988, 04, 30);
            //Console.WriteLine(myBirthday.ToShortDateString());

            DateTime myBirthday = DateTime.Parse("4/30/1988");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalHours);
            Console.ReadLine();
            
        }
    }
}