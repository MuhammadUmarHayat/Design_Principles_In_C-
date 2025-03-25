using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
    // Interface Segregation Principle (ISP)
    // Interfaces are specific to the needs of the client. No unused methods.
    interface ILogger
    {
        void Log(string message);
    }

    
}
