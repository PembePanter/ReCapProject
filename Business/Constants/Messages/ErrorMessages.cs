using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants.Messages
{
    public class ErrorMessages
    {
        public static string CarIsNotReturned = "Araba henüz iade edilmedi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string CarNameInvalid = "Araba ismi en az 2 karakter olmalıdır.";
        public static string InsufficientCarPrice = "Arabanın günlük fiyatı 0'dan büyük olmalıdır.";
    }
}
