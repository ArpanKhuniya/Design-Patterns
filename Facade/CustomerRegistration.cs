using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CustomerRegistration
    {
        public void RegisterCustomer() {
            Validator validator = new Validator();
            validator.ValidateInput();

            EmailCustomer customer = new EmailCustomer();
            customer.SendMail();

            CustomerDataAccessLayer customerDataAccessLayer = new CustomerDataAccessLayer();
            customerDataAccessLayer.ProvideDataAccess();
        }

    }
}
