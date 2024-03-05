using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public interface IResult
    {
        bool Success { get; } 
        string Message { get; }

        //Bu kısımda bir metot öncüsü değilde bir özellik öncüleri oluşturuyoruz.
        //Success ve Message değişkenleri sadece okunabilir olmalı üzerlerinde işlem yapmak istemiyoruz.
        //Bizler için o anki işlemin başarı durumunu ve detayını(mesajı: işlem başarılı-değil vb.) tutacaklar.
    }
}
