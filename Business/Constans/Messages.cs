using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public class Messages
    {
        public static string CarNameInValid = "Araba Adı 2 Karakterden Az Olmamalıdır!";
        public static string CarAdded = "Araba Başarıyla Eklendi!";
        public static string MaintenanceTime = "Sistem Bakım Saatinde!";
        public static string RentalAddedError = "Araba henüz teslim edilmemiş!";
        public static string RentalAddedSuccess = "Kiralama işlemi başarıyla oluşturuldu!";

        public static string ImageCountLimitError = "Fotoğraf sayısı sınırına ulaşıldı. Bir arabanın en fazla 5 adet fotoğrafı olabilir!";
        public static string CarImageAdded = "Araba fotoğrafları başarıyla eklendi";

        public static string CarImageUpdate = "Fotoğraf bilgileri başarıyla güncellendi!";
    }
}
