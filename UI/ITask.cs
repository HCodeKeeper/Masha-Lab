using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masha_Lab.UI
{
    internal interface ITask
    {
        string GetTitle();

        string GetDescription();

        string[] GetInputData();

        string[] GetOutputData();

        int GetUID();
    }
}
