using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  internal class Phone3G : Phone
  {
    public override void Connect()
    {
      Console.WriteLine("Connect to gsm 3g station...");
    }
  }
}
