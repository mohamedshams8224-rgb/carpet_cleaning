namespace carpet_cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int num1;
            int num2;
            int sum; 
            double tax;
            double cost; 


            Console.WriteLine("Welcome to carpet cleaning service!");
            Console.WriteLine("Professional carpet cleaning using advanced \n " +
                "techniques to deliver deep cleanliness and bring back your carpet’s original freshness and shine.\n \n ");
            Console.WriteLine("number of small carpets : ");
            num1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("number of large carpets : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price of small carpet = $25");
            Console.WriteLine("Price of large carpet = $35");

            //operations
            sum = (num1*25) + (num2*35); 
            tax = sum * 0.06; 
            cost = sum + tax;

            Console.WriteLine($"cost = ${sum}");
            Console.WriteLine($"Tax = ${tax}");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"total stimate = ${cost.ToString("f1")}");
            Console.WriteLine("this estimate is valid for 30 years");




        }
    }
}
