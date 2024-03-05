using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        //Interface de sadece get ile oluşturduğumuz özellikler için implement yöntemi şu şekilde
        public bool Success { get; }
        public string Message { get; }

        //Şimdi Result metodlarımızı oluşturacağız. Bu metodlar override olacak imza kısımlarına göre kendisi otomatik seçilim yapacak

        public Result(bool success, string message):this(success) //eğer kullanıcı succes değeri almak isterse
                                                                  //aşağıda kullanılan metodun çağırması için
                                                                  //this(success) kullandık. Bu şekilde içine
                                                                  //yazdığımız imzası ile hangi metodu kast ettiğimizi anladı
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
