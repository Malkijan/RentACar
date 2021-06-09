using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        #region Car

        public static string CarsListed = "Arabalar listelendi.";
        public static string CarListed = "Araba listelendi.";
        public static string CarsListedByBrand = "Arabalar Modellerine göre listelendi.";
        public static string CarsListedByColor = "Arabalar renklerine göre listelendi.";
        public static string CarsListedByDailyPrice = "Arabalar günlük fiyat aralığına göre listelendi.";
        public static string CarsListedByModelYear = "Arabalar model yılına göre listelendi.";
        public static string CarAdded = "Araba başarıyla eklendi.";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarDeleted = "Araba başarıyla silindi.";
        
        public static string CarDailyPriceInvalid = "Araba için günlük fiyat hatalı!";


        #endregion

        #region Brand

        public static string BrandNameInvalid = "Araba markası 2 karakterden fazla olmalıdır.";
        public static string BrandNameNotEmpty = "Araba markası boş olamaz!";


        #endregion

        #region Customer

        public static string CustomerAdded = "Müşteri sisteme eklendi.";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi.";
        public static string CustomerDeleted = "Müşteri sistemden silindi.";
        public static string CustomersListed = "Müşteriler listelendi.";


        #endregion

        #region Rental

        public static string RentalAdded = "Araba kiralanması başarıyla eklendi.";
        public static string RentalUpdated = "Araba kiralanması başarıyla güncellendi";
        public static string RentalDeleted = "Kiralanmış araba başarıyla silindi.";
        public static string RentalsListed = "Kiralanan tüm arabalar listelendi.";

        #endregion

        #region Brand

        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandListed = "Marka listelendi.";
        public static string BrandAdded = "Marka başarıyla eklendi.";
        public static string BrandUpdated = "Marka başarıyla güncellendi.";
        public static string BrandDeleted = "Marka başarıyla silindi.";


        #endregion

        #region CarImages

        public static string CarImagesListed = "Araba görselleri listelendi.";
        public static string CarImageAdded = "Araba görseli başarıyla eklendi.";
        public static string CarImageUpdated="Araba görseli güncellendi.";
        public static string CarImageDeleted = "Araba görseli başarıyla silindi.";
        public static string CheckIfImageLimitExceeded = "Araba için maksimum 5 görsel olabilir.";


        #endregion

        #region Color

        public static string ColorsListed = "Tüm renkler listelendi.";
        public static string ColorAdded = "Renk başarıyla eklendi.";
        public static string ColorUpdated = "Renk başarıyla güncellendi.";
        public static string ColorDeleted = "Renk başarıyla silindi.";


        #endregion

        #region Users

        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserUpdated = "Kullanıcı başarıyla güncellendi.";
        public static string UserDeleted = "Kullanıcı başarıyla silindi.";
        public static string UsersListed = "Tüm kullanıcılar listelendi.";
        public static string UserRegistered = "Kullanıcı başarıyla sisteme kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserPasswordError = "Kullanıcı şifre bilgisi hatalı.";
        public static string UserSuccessfulLogin = "Kullanıcı girişi başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
        public static string AccessTokenCreated = "Kullanıcı için Token oluşturuldu.";
        public static string AuthorizationDenied = "Kullanıcının yetkisi yok!";

        #endregion
    }
}
