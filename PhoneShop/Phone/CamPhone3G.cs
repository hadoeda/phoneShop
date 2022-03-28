using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  /// <summary>
  /// 3G Телефон с камерой.
  /// </summary>
  internal sealed class CamPhone3G : Phone3G
  {
    #region Поля и свойства

    /// <summary>
    /// Камера.
    /// </summary>
    private readonly ICamera camera;

    #endregion

    #region Методы

    /// <summary>
    /// Сделать фото.
    /// </summary>
    public void GetPhoto()
    {
      Console.WriteLine("Camera shot start");
      this.camera.Shot();
    }

    private void ShotCompletedHandler(object sender, ShotEventArgs e)
    {
      Console.WriteLine("Camera shot completed");
    }

    #endregion

    #region Конструкторы
    
    /// <summary>
    /// Конструктор.
    /// </summary>
    public CamPhone3G()
    {
      this.camera = new Camera();
      this.camera.ShotCompleted += this.ShotCompletedHandler;
    }

    #endregion
  }
}
