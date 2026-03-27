using ObModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillDataService
{
    public interface IOB
    {
        void Add(Bills bills);
        List<Bills> GetBills();
    }
}
