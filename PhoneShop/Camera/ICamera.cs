using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  internal interface ICamera
  {
    /// <summary>
    /// Событие "Снимок сделан"
    /// </summary>
    event EventHandler<ShotEventArgs> ShotCompleted;

    /// <summary>
    /// Сделать снимок
    /// </summary>
    void Shot();
  }
}
