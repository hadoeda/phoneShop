using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  /// <summary>
  /// Данные снимка.
  /// </summary>
  internal sealed class ShotEventArgs: EventArgs
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
