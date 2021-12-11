using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Lab.UI
{
    internal class TaskFrame
    {
        ITask Task;
        public TaskFrame(ITask task)
        {
            Task = task;
        }

        void Draw()
        {
            Console.WriteLine($"Title: {Task.GetTitle}");
            Console.WriteLine($"Page Code\tDescription");
            Console.WriteLine();
            foreach(string input in Task.GetInputData())
            {
                Console.WriteLine("Input: " + input);
                Console.Write("~Output: ");
                foreach (string resultEl in Task.GetOutputData())
                {
                    Console.Write($"'{resultEl}', ");
                }
                Console.WriteLine();
            }
        }
    }
}
