using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPricipleExample
{
   public  interface INotifier
    {
        void Send(Notification notification);
    }
}
