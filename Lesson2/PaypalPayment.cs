

using Myspace;

namespace Lesson2
{
    internal class PaypalPayment :IPayment
    {
        private List<PayInfo> payInfos = new List<PayInfo>();
         public void ProcessPayment(int sum)
        {
            PayInfo tmp = new PayInfo();
            tmp.sum = sum;
            if (sum > 100000)
            {
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
        public string GetPapalPayHistory()
        {
            string history = "Paypal payment history:\n";
            int i = 1;
            foreach (PayInfo p in payInfos)
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
