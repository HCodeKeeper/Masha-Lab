using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Masha_Lab.UI
{
    internal class MainFrame
    {
        ITask[] Tasks;
        TaskFrame TaskFrame;

        public MainFrame(ITask[] tasks)
        {
            Tasks = tasks;
            Draw();
            InviteToInput();
        }

        void Draw()
        {
            Console.WriteLine("Task\t\tPage Code");
            foreach(ITask task in Tasks)
            {
                Console.WriteLine($"{task.GetTitle()}\t{task.GetUID()}");
            }
            Console.WriteLine("\nAuthor: Not Mashik");
        }

        void SetTaskFrame(TaskFrame taskFrame)
        {
            TaskFrame = taskFrame;
        }

        void NavigateTask(ITask task)
        {
            SetTaskFrame(new TaskFrame(task));
        }

        ITask getTaskByUID(int uid)
        {
            foreach(ITask task in Tasks)
            {
                if (task.GetUID() == uid)
                {
                    return task;
                }
            }
            return null;
        }

        bool InviteToInput()
        {
            Console.WriteLine("Enter the page code or 'q' to exit");
            string key = Console.ReadLine();
            if(key == "q")
            {
                return true;
            }
            if (int.TryParse(key, out int uid))
            {
                ITask task = getTaskByUID(uid);
                if (task != null)
                {
                    NavigateTask(task);
                }
            }
            InviteToInput();
            return true;
        }
    }
}
