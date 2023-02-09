namespace MethodOverloading
{
    public class Program
    {
       public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }
       public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool Mybool)
        {
            var sum = num1 + num2;
            if(Mybool == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString() ; 
            }


        }

        static void Main(string[] args)
        {
            var ans = Add(1, 2, true);
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2.3m, 3.4m));
            Console.WriteLine(ans);
            Console.WriteLine(Add(2, 3, true));
             

        }
        


    }
}
