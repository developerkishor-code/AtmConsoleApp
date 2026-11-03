using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace AtmConsoleApp.Collections
{
    public class HashTablePractiseCode
    {
        Hashtable ht = new Hashtable();
       
       public void addItemsToHashTable()
        {
            ht.Add("emp_name", "Scott");
            ht.Add("emp_id", 101);
            ht.Add("emp_salary", 10000);
            ht.Add("emp_designation", "Manager");
            ht.Add("emp_department", "IT");
            ht.Add("emp_location", "Bangalore");
            ht.Add("emp_email", "scott@company.com");
        }

        public void displayAllItemFromHashTable()
        {
            foreach(object key in ht.Keys)
            {
                Console.WriteLine($"Key: {key} : {ht[key]}");
            }
        }

    }
}