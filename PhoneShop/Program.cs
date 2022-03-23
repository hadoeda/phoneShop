using System;

namespace PhoneShop
{
  /// <summary>
  /// Основной класс приложения.
  /// </summary>
  public class Program
  {
    #region Методы
    /// <summary>
    /// Стандартная точка входа в приложение.
    /// </summary>
    /// <param name="args">Аргументы командной строки.</param>
    public static void Main(string[] args)
    {
      Console.WriteLine("Phones");
      TestPhone(new Phone());

      Console.WriteLine();
      TestPhone(new Phone3G());

      Console.WriteLine();
      TestPhone(new CamPhone3G());

      Console.ReadLine();
    }

    /// <summary>
    /// Тестирование телефона.
    /// </summary>
    /// <param name="phone">Телефон.</param>
    private static void TestPhone(IPhone phone)
    {
      try
      {
        Console.WriteLine("Phone IMEI {0}", phone.Imei);
        Console.WriteLine("Phone SIM card number {0}", phone.SimNumber);
        phone.Call(Phone.EuEmergencyNumber);
        phone.Call(Phone.UsEmergencyNumber);
        phone.Call(123);
        phone.Call("Jane");

        if (phone is CamPhone3G camPhone)
        {
          camPhone.GetPhoto();
        }
      }
      catch(Exception e)
      {
        Console.WriteLine("Error: {0}", e.Message);
      }
    }

    #endregion
  }
}
