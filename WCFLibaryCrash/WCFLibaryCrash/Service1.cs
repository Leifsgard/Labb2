using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLibaryCrash
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            MyFault myfault = new MyFault()
            {
                Type = "Myfault, kunde inte lägga till användaren i databasen",
                User = "Freddie",
                TimeStamp = DateTime.Now.ToShortTimeString()
            };
            throw new FaultException<MyFault>(myfault, "Extra info LOL:-)");

            // return string.Format("You entered: {0}", value);
            ApplicationException exception = new ApplicationException("ApplicationException");
            throw new FaultException<ApplicationException>(exception, "Mer information");
            //enkla sättet
            //throw new FaultException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
