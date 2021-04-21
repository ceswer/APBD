using System;
using System.Collections.Generic;

namespace LinqTutorials
{
    class Program
    {

        static void show(IEnumerable<object> task)
        {
            foreach (var obj in task) Console.WriteLine(obj);
            Console.WriteLine("NEW TASK");
        }

        static void Main(string[] args)
        {
            show(LinqTasks.Task1());
            show(LinqTasks.Task2());
            Console.WriteLine(LinqTasks.Task3());
            show(LinqTasks.Task4());
            show(LinqTasks.Task5());
            show(LinqTasks.Task6());
            show(LinqTasks.Task7());
            Console.WriteLine(LinqTasks.Task8());
            Console.WriteLine(LinqTasks.Task9());
            show(LinqTasks.Task10());
            show(LinqTasks.Task11());
            show(LinqTasks.Task12());
            // task 13 is OK, I swear
            show(LinqTasks.Task14());
        }
    }
}
