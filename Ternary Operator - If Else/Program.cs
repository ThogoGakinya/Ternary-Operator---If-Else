namespace Ternary_Operator___If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Checker();
        }

        public static void Checker() 
        {
            int storedTemp;
            Console.WriteLine("Please Enter Temperature");
            string temp = Console.ReadLine();

            bool checkInteger = int.TryParse(temp, out storedTemp);

            if (checkInteger) 
            {
                string status = storedTemp <= 15 ? "It is too cold here" : storedTemp >= 16 && storedTemp <= 28 ? "It is Ok" : "It is not here";
                Console.WriteLine(status);
            }
            else
            {
                Console.WriteLine("Please enter an iunteger");
            }

            
        }
    }
}
