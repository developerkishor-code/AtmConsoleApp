using AtmConsoleApp.Collections;

Console.WriteLine("Enter the five favourite items to add in ArrayList");
string [] items = Console.ReadLine().Split(',');
ArrayListPracticeCode arrayListPracticeCode = new ArrayListPracticeCode();
arrayListPracticeCode.addItemsToAyyarList(items);
arrayListPracticeCode.displayItemsFromArrayList();
