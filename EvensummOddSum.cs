namespace RajendraConsoleApp.FunctionAndArray
{
    public class EvenSumOddSum
    {
       public int Evensum = 0;
        int Oddsum = 0;
        public void SumOfNumber()
        {

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                   
                    Console.WriteLine(i + " ");
                    Evensum+=i;
                }

                
            }
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine(i + " ");
                    Oddsum += i;
                }


            }
            Console.WriteLine("Even sum : " + Evensum);
           
            

            Console.WriteLine("Odd sum : " + Oddsum);
        }

      static void Main(string[] args)
            {

                EvenSumOddSum obj = new EvenSumOddSum();
                obj.SumOfNumber();

           
            

        }
        
        }   
    
    
}