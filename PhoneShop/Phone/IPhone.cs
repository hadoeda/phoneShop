using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{
  internal interface IPhone
  {
    /// <summary>
    /// IMEI телефона
    /// </summary>
    string Imei { get; }
    
    /// <summary>
    /// Номер SIM карты телефона
    /// </summary>
    string SimNumber { get; set; }

    /// <summary>
    /// Вызов номера.
    /// Должен выбрасывать исключение если нет сим карты
    /// если номер не является номером службы спасения
    /// </summary>
    /// <param name="number">Номер телефона</param>
    void Call(string name);

    /// <summary>
    /// Вызов по имени в адресной книге.
    /// Выбрасывает исключение если номер не найден в адресной книге.
    /// Должен выбрасывать исключение если нет сим карты
    /// если номер не является номером службы спасения.
    /// </summary>
    /// <param name="name">Имя абонента из адресной книги</param>
    void Call(uint phoneNumber);
    
    /// <summary>
    /// Подключение к станции
    /// </summary>
    void Connect();
  }
}
