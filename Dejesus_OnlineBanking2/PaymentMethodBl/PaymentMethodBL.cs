using BillDataService;
using ObModels;
using System.Security.Principal;

namespace PaymentMethodBl
{
    public class PaymentMethodBL
    {
        OBdataservice ob = new OBdataservice(new OBDBData());
        OBJson j = new OBJson();
        public Bills AddBill(string pm, string bt, string name, int num, double amount)
        {

            Bills bill = new Bills
            {
                PaymentMethod = pm,
                BillType = bt,
                AccountName = name,
                AccountNumber = num,
                BillAmount = amount
            };

            ob.Add(bill);
            j.Add(bill);
            return bill;

        }
    }
}