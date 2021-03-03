﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Kategoride 10 üründen fazla ürün olamaz ";
        public static string ProductNameAlreadyExist = "Bu kategoride zaten böyle bir ürün var";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
        
