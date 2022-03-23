using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    #region Интерфейс IPhone
    
    /// <summary>
    /// IMEI телефона.
    /// </summary>
    private readonly string imei;

    public string Imei => imei;

    /// <summary>
    /// Номер сим карты телефона.
    /// </summary>
    private string simNumber;

    public string SimNumber 
    { 
      get => simNumber; 

      set => simNumber = value; 
    }

    public void Call(uint phoneNumber)
    {
      if(phoneNumber == EuEmergencyNumber || phoneNumber == UsEmergencyNumber)
      {
        this.Connect();
        Console.WriteLine("Emergency call {0}", phoneNumber);
        return;
      }

      if (string.IsNullOrEmpty(simNumber)) 
        throw new Exception("Emergency calls only...");
  
      this.Connect();
      Console.WriteLine("Call to phone number {0}", phoneNumber);
    }

    public void Call(string name)
    {
      if (!this.book.TryGetValue(name, out uint number)) 
        throw new Exception($"I don't find phone by {name} in phone book");

      this.Call(number);
    }

    public virtual void Connect()
    {
      Console.WriteLine("Connect to gsm station...");
    }

    #endregion

    #region Конструкторы

    /// <summary>
    /// Конструктор.
    /// </summary>
    public Phone()
    {
      this.imei = $"some_imei_{Guid.NewGuid()}";
      this.simNumber = $"some_sim_{Guid.NewGuid()}";
      this.book.Add("Jane", 673490);
    }
    
    #endregion
  }
}
