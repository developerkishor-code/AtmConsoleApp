using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmConsoleApp.Collections
{
    public class DictionaryPractiseCode
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public void addItemsToDictionary()
        {
            dictionary.Add("emp_name", "Scott");
            dictionary.Add("emp_email", "scott@email.com");
            dictionary.Add("emp_phone", "5685858");
            dictionary.Add("emp_address", "Bangalore");
            dictionary.Add("emp_department", "Software Engineer");
            dictionary.Add("emp_position", "Junior Developer");
        }

        public void displayItemsFromDictionary()
        {
            foreach (var items in dictionary)
            {
                Console.WriteLine(items.Key + ": " + items.Value);
            }
        }
    }
}