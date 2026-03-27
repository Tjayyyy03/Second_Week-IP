using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ObModels;

namespace BillDataService
{
    public class OBJson
    {
        private List<Bills> ob = new List<Bills>();

        private string _jsonFileName;

        public OBJson()
        {
            _jsonFileName = $"{AppDomain.CurrentDomain.BaseDirectory}/objson.json";

            PopulateJsonFile();
        }

        private void PopulateJsonFile()
        {
            RetrieveDataFromJsonFile();

            if (ob.Count <= 0)
            {
                ob.Add(new Bills { BillType = "Product price", BillAmount = 370, PaymentMethod = "Gcash", AccountName = "tom", AccountNumber = 300  });
                ob.Add(new Bills { BillType = "Electric bill", BillAmount = 1500, PaymentMethod = "paymaya", AccountName = "gabe", AccountNumber = 200 });
                ob.Add(new Bills { BillType = "Water bill", BillAmount = 800, PaymentMethod = "paypal", AccountName = "khyran", AccountNumber = 100 });
               

                SaveDataToJsonFile();
            }
        }

        private void SaveDataToJsonFile()
        {
            using (var outputStream = File.OpenWrite(_jsonFileName))
            {
                JsonSerializer.Serialize<List<Bills>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    { SkipValidation = true, Indented = true })
                    , ob);
            }
        }

        private void RetrieveDataFromJsonFile()
        {
            using (var jsonFileReader = File.OpenText(this._jsonFileName))
            {
                this.ob = JsonSerializer.Deserialize<List<Bills>>
                    (jsonFileReader.ReadToEnd(), new JsonSerializerOptions
                    { PropertyNameCaseInsensitive = true })
                    .ToList();
            }
        }

        public void Add(Bills bills)
        {
            ob.Add(bills);
            SaveDataToJsonFile();
        }

        public List<Bills> GetBills()
        {
            RetrieveDataFromJsonFile();
            return ob;
        }
    }
}
