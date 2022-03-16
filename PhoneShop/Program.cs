using System;

namespace PhoneShop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Phones");
      TestPhone(new Phone());

      Console.WriteLine();
      TestPhone(new Phone3G());

      Console.WriteLine();
      TestPhone(new CamPhone3G());

      Console.ReadLine();
    }

   static void TestPhone(IPhone phone)
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
  }
}
