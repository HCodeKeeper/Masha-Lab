using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Lab.UI
{
    internal class Task : ITask
    {
        string Title;
        string Description;
        string[] Input;
        string[] Output;
        int experUID;
        public Task(string title, string descr, string[] input, string[] output)
        {
            Title = title;
            Description = descr;
            Input = input;
            Output = output;
            experUID = new Random().Next(100, 1000);
        }

        public string GetDescription()
        {
            return Description;
        }

        public string[] GetInputData()
        {
            return Input;
        }

        public string[] GetOutputData()
        {
            return Output;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetUID()
        {
            return experUID;
        }
    }
}
