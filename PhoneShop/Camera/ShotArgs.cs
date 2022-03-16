using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  internal sealed class ShotEventArgs: EventArgs
  {
    private readonly byte[] image;

    /// <summary>
    /// Контент снимка
    /// </summary>
    public byte[] Image => image;

    public ShotEventArgs(byte [] image)
    {
      this.image = image;
    }
  }
}
