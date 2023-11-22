using Lesson2;

namespace Myspace;
class Program
{
    static void Main(string[] args)
    {
        PaypalPayment paypal = new PaypalPayment();
        CreditCardPayment credit = new CreditCardPayment();
        string sum = "";
        while (true)
        {
            try
            {
                Console.WriteLine("Choose the pay system:");
                Console.WriteLine("Paypal ------ 1");
                Console.WriteLine("Credit Card - 2");
                Console.WriteLine("Exit -------- e");
                string menu;
                menu = Console.ReadLine();
                if (menu == "e")
                {
                    break;
                }
                else if (menu == "1")
                {
                    Console.WriteLine("Input Sum for payment");
                    sum = Console.ReadLine();
                    paypal.ProcessPayment(int.Parse(sum));
                }
                else if (menu == "2")
                {
                    Console.WriteLine("Input Sum for payment");
                    sum = Console.ReadLine();
                    credit.ProcessPayment(int.Parse(sum));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong input");
            }
        }

        Console.WriteLine(paypal.GetPapalPayHistory());
        Console.WriteLine(credit.GetCreditPayHistory());

    }
}
