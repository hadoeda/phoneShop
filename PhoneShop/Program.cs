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

      var simplePhone = new Phone();
      InitPhone(simplePhone);
      TestPhone(simplePhone);

      Console.WriteLine();
      var phone3g = new Phone3G();
      InitPhone(phone3g);
      TestPhone(phone3g);

      Console.WriteLine();
      var camPhone3G = new CamPhone3G();
      InitPhone(camPhone3G);
      TestPhone(camPhone3G);

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
      catch (Exception ex)
      {
        Console.WriteLine("Error: {0}", ex.Message);
      }

    }


    /// <summary>
    /// Инициализация для теста
    /// </summary>
    /// <param name="phone">Телефон</param>
    private static void InitPhone(IPhone phone)
    {
      phone.SimNumber = $"some_sim_{Guid.NewGuid()}";
      phone.AddToBook("Jane", 673490);
    }

    #endregion
  }
}
