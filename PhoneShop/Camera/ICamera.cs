using System;

namespace PhoneShop
{
  /// <summary>
  /// Интерфейс камеры.
  /// </summary>
  internal interface ICamera
  {
    /// <summary>
    /// Событие "Снимок сделан".
    /// </summary>
    event EventHandler<ShotEventArgs> ShotCompleted;

    /// <summary>
    /// Сделать снимок.
    /// </summary>
    void Shot();
  }
}
