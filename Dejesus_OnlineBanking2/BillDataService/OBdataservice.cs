using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ObModels;

namespace BillDataService
{
    public class OBdataservice
    {
        IOB _dataService;
        public OBdataservice(IOB dataservice)
        {
            _dataService = dataservice;
        }

        public void Add(Bills bills)
        {
            _dataService.Add(bills);
        }
        public List<Bills> GetBills()
        {
            return _dataService.GetBills();
        }
    }
}
