using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  /// <summary>
  /// Камера.
  /// </summary>
  internal sealed class Camera : ICamera
  {
    #region ICamera

    public event EventHandler<ShotEventArgs> ShotCompleted;
    
    public void Shot()
    {
      ShotCompleted?.Invoke(this, new ShotEventArgs(Array.Empty<byte>()));
    }

    #endregion
  }
}
