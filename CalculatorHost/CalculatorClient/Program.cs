using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient client = new CalculatorClient();

            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = client.Add(value1, value2);
            conso
        }
    }
}
