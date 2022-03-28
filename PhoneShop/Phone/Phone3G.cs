using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  /// <summary>
  /// Телефон с 3G.
  /// </summary>
  internal class Phone3G : Phone
  {
    #region IPhone

    public override void Connect()
    {
      Console.WriteLine("Connect to gsm 3g station...");
    }

    #endregion
  }
}
