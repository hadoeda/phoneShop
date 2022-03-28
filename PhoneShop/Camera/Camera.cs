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
      OnShotCompleted(new ShotEventArgs(Array.Empty<byte>()));
    }

    #endregion

    #region Методы

    /// <summary>
    /// Генерирует событие "Снимок сделан".
    /// </summary>
    /// <param name="args">Данные снимка.</param>
    public void OnShotCompleted(ShotEventArgs args)
    {
      if (ShotCompleted != null)
        ShotCompleted(this, args);
    }

    #endregion
  }
}
