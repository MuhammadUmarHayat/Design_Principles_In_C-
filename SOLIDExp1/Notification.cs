using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
    // Single Responsibility Principle (SRP)
    // Each class has a single reason to change.
    public class Notification
    {
        public string Message { get; set; }
        public string Recipient { get; set; }
    }

}
