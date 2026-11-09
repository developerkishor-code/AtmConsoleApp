using System;
using System.Collections;


namespace AtmConsoleApp.Collections
{
    public class ArrayListPracticeCode
    {
        ArrayList al = new ArrayList();

        public void addItemsToAyyarList(string[] items)
        {
            foreach (var item in items)
            {
                al.Add(item);
            }
        }

        public void displayItemsFromArrayList()
        {
            foreach (var items in al)
            {
                Console.WriteLine($"Your inserted item is: {items}");
            }
        }

    }
}