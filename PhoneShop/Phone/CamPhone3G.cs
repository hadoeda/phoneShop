using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  internal class CamPhone3G : Phone3G
  {
    /// <summary>
    /// Объект камеры
    /// </summary>
    private readonly ICamera camera;
    
    /// <summary>
    /// Сделать фото
    /// </summary>
    public void GetPhoto()
    {
      Console.WriteLine("Camera shot start");
      this.camera.Shot();
    }

    /// <summary>
    /// Обработчик события "Снимок сделан"
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ShotCompletedHandler(object sender, ShotEventArgs e)
    {
      Console.WriteLine("Camera shot completed");
    }

    public CamPhone3G()
    {
      this.camera = new Camera();
      this.camera.ShotCompleted += this.ShotCompletedHandler;
    }
  }
}
