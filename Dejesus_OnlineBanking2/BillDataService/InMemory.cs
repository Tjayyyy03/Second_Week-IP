using ObModels;

namespace BillDataService
{
    public class InMemory
    {
        private List<Bills> bills = new List<Bills>();

        public void Add(Bills bill)
        {
            bills.Add(bill);
        }

        public List<Bills> GetBills()
        {
            return bills;
        }
    }
}