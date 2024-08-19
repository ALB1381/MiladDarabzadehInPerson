using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiladDarabzadeh.Core.Senders
{
    public static class SendSms
    {

        public static bool KeveNegarSender(string ActivateCode,string PhoneNumber,string type = "verfy")
        {
            //try
            //{
            //    Kavenegar.KavenegarApi api = new Kavenegar.KavenegarApi("6A68325851337357565A5A72412F4132316F4D465856566368683664724568592F6868713468394E6A506B3D");
            //    var result = api.VerifyLookup(PhoneNumber, ActivateCode, type);
            //    return true;
            //}
            //catch (Kavenegar.Exceptions.ApiException ex)
            //{
            //    // در صورتی که خروجی وب سرویس 200 نباشد این خطارخ می دهد.
            //    Console.Write("Message : " + ex.Message);
            //    return false;
            //}
            //catch (Kavenegar.Exceptions.HttpException ex)
            //{
            //    // در زمانی که مشکلی در برقرای ارتباط با وب سرویس وجود داشته باشد این خطا رخ می دهد
            //    Console.Write("Message : " + ex.Message);
            //    return false;
            //}
            return false;
        }
    }
}
