using System;
using System.Collections.Generic;

namespace PhoneShop
{
  /// <summary>
  /// Класс телефон.
  /// </summary>
  internal class Phone : IPhone
  {
    #region Константы

    /// <summary>
    /// Номер службы спасения в Европе.
    /// </summary>
    public const uint EuEmergencyNumber = 112;

    /// <summary>
    /// Номер службы спасения в США.
    /// </summary>
    public const uint UsEmergencyNumber = 911;

    #endregion

    #region Поля и свойства

    /// <summary>
    /// Адресная книга.
    /// </summary>
    private readonly Dictionary<string, uint> book = new();

    #endregion

    #region IPhone

    public string Imei { get; }

    public string SimNumber { get; set; }

    public void Call(uint phoneNumber)
    {
      if (phoneNumber == EuEmergencyNumber || phoneNumber == UsEmergencyNumber)
      {
        this.Connect();
        Console.WriteLine("Emergency call {0}", phoneNumber);
        return;
      }

      if (string.IsNullOrEmpty(this.SimNumber))
        throw new Exception("Emergency calls only...");

      this.Connect();
      Console.WriteLine("Call to phone number {0}", phoneNumber);
    }

    public void Call(string name)
    {
      if (!this.book.TryGetValue(name, out uint number))
        throw new ArgumentException($"Number not found in phone book", nameof(name));

      this.Call(number);
    }

    public virtual void Connect()
    {
      Console.WriteLine("Connect to gsm station...");
    }

    public void AddToBook(string name, uint phoneNumber)
    {
      this.book.Add(name, phoneNumber);
    }

    public void RemoveFromBook(string name)
    {
      this.book.Remove(name);
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public Phone()
    {
      this.Imei = $"some_imei_{Guid.NewGuid()}";
    }

    #endregion
  }
}
