public class HelloWorld
{
    public static void Main(string[] args)
    {
         int r, rev = 0;
         
            Console.WriteLine("Enter any number");
            int n=Convert.ToInt32(Console.ReadLine());
            int on=n;
            while(n>0)
            {
                r = n % 10;
                
                rev = (rev * 10 )+ r;
                n = n / 10;
            }
            Console.WriteLine("Reverse number: "+rev);
    
    if(on==rev)
    {
                Console.WriteLine("Palindrome number ");
    }
    else {
        
                Console.WriteLine("Not a palindrome number");
    }
    }
}