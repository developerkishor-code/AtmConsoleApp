using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmConsoleApp.CollectionExercise
{
    public class CollecionExercies1
    {
        public List<string> tasks = new List<string>
        {
          "Write Readme",
          "Add unit tests",
          "Review PR",
          "Set up Docker",
          "Fix login bug"
        };
        public void addTask()
        {
            tasks.Add("Deploy to test");
        }

        public void removeTask()
        {
            tasks.Remove("Review PR");
        }

        public void sortTask()
        {
            tasks.Sort();
        }

        public void printAllTask()
        {
            foreach (var task in tasks)
            {
                Console.Write(task);
                if (task != tasks.Last())
                {
                    Console.Write(", ");
                }

            }
        }

        public void titleThatContentFirstTest()
        {
            Console.WriteLine();
            foreach (var task in tasks)
            {
                if (task.Contains("test"))
                {
                    Console.WriteLine(task);
                    break;
                }
            }
        }

        public void runCollectionExercise1()
        {
            addTask();
            removeTask();
            sortTask();
            printAllTask();
            titleThatContentFirstTest();
        }
    }
}