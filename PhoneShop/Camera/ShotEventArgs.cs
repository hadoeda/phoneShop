using System;

namespace PhoneShop
{
  /// <summary>
  /// Аргумент события "Снимок сделан".
  /// </summary>
  internal sealed class ShotEventArgs : EventArgs
  {
    #region Поля и свойства

    /// <summary>
    /// Изображение.
    /// </summary>
    public byte[] Image { get; }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="image">Изображение.</param>
    public ShotEventArgs(byte[] image)
    {
      this.Image = image;
    }

    #endregion
  }
}
