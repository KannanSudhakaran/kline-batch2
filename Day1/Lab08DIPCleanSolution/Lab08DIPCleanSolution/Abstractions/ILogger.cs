using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08DIPCleanSolution.Abstractions
{
    internal interface ILogger
    {
        void Log(Exception ex);
    }
}
