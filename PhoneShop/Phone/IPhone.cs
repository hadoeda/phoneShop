using System;

namespace PhoneShop
{
  /// <summary>
  /// Телефон.
  /// </summary>
  internal interface IPhone
  {
    /// <summary>
    /// IMEI телефона.
    /// </summary>
    string Imei { get; }

    /// <summary>
    /// Номер SIM карты телефона.
    /// </summary>
    string SimNumber { get; set; }

    /// <summary>
    /// Вызов по имени в адресной книге.
    /// </summary>
    /// <param name="name">Имя абонента из адресной книги.</param>
    /// <exception cref="Exception">Нет сим карты и вызываемый номер не номер службы спасения.</exception>
    /// <exception cref="ArgumentException">Номер не найден в адресной книге.</exception>
    void Call(string name);

    /// <summary>
    /// Вызов номера.
    /// </summary>
    /// <param name="phoneNumber">Номер телефона.</param>
    /// <exception cref="Exception">Нет сим карты и вызываемый номер не номер службы спасения.</exception>
    void Call(uint phoneNumber);

    /// <summary>
    /// Добавить запись в адресную книгу.
    /// </summary>
    /// <param name="name">Имя обонентка.</param>
    /// <param name="phoneNumber">Номер телефона абонента.</param>
    void AddToBook(string name, uint phoneNumber);

    /// <summary>
    /// Удалить запись из адресной книги.
    /// </summary>
    /// <param name="name">Имя абонента.</param>
    void RemoveFromBook(string name);
  }
}
