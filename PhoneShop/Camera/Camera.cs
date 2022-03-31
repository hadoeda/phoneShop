using System;

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
      this.OnShotCompleted(new ShotEventArgs(Array.Empty<byte>()));
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
        this.ShotCompleted(this, args);
    }

    #endregion
  }
}
