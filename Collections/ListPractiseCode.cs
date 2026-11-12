namespace AtmConsoleApp.Collections;

public class ListPractiseCode
{
    List <int> iList = new List<int>();
    public void addItemsToList()
    {
        iList.Add(100);
        iList.Add(200);
        iList.Add(300);
        iList.Insert(1, 150); 
       /*Below Line will give errror because List is strongly typed collection
        and we are trying to add string value in it.*/  
        //iList.Add("Bhanu");
    }
    public void displayItemsFromList()
    {
        foreach(int x in iList)
        {
            Console.WriteLine(x);
        }
    }

    public void removeItemFromGivenIndex(int index)
    {
        iList.RemoveAt(index);
    }

}