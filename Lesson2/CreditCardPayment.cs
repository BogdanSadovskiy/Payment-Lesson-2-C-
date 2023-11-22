

using static Myspace.IPayment;

namespace Myspace
{
    internal class CreditCardPayment : IPayment
    {
        private List<PayInfo> payInfos = new List<PayInfo>();


       public void ProcessPayment(int sum)
        {
            PayInfo tmp = new PayInfo();
            tmp.sum = sum;
            if (sum > 10000) {
                tmp.successPay = false;
                Console.WriteLine("Sum is too big");
                payInfos.Add(tmp);
            }
            else
            {
                tmp.successPay = true;
                Console.WriteLine("Success");
                payInfos.Add(tmp);  
            }
          
        }
        public string GetCreditPayHistory()
        {
            string history = "Credit Card history:\n";
            int i = 1;
            foreach(PayInfo p in payInfos)
            {
                history += "\t" + i.ToString() + "\n";
                i++;
                history += "Sum - " + p.sum.ToString() + "\n";
                if (p.successPay)
                {
                    history += "Status - Success\n";
                }
                else
                {
                    history += "Status - Unsuccsess\n";
                }
            }
            return history;
        }
    }
}
