using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUi
{
    public class Counter
    {
        public int LoopCounter { get; set; }

        public override string ToString()
        {
            return LoopCounter.ToString();
        }
    }
}
