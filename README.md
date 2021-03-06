# Rent A Car
Araba Kiralama Projesi Backend

<br><p align="center"><img width="75%" src="https://i.ibb.co/Dbwxd8Y/Rent-ACar-Banner.png"></p>

## :pushpin:Proje Hakkında <br/>
**N-Katmanlı** mimari kullanılıarak hazırlanan bu projede **Solid** presiplerine uygun bir şekilde dizayn edildi. Özellikle katmanlar arası bağımlılıklar **loose coupling** ilkesini baz
alarak gerçekleştirildiğinden ileride olası bir teknoloji değişikliği için bizlere çok büyük bir rahatlık sağlamaktadır. Yeni teknolojimizi ekleyip sadece configlerimizi
değiştirmemiz yeterli olmaktadır. Veri katmanımızla haberleşmek için **Entity Framework**'u kullanırken, bağımlılıkları çözmek için **Autofac**'den yararlandık.
**Aspect Oriented Programming**'in nimetlerinden yararlanarak methodlarımızı spagetti kodlardan uzak bir şekilde tertemiz ele aldık. Bunlardan başlıcaları **Caching**, **Validation**, **Transaction**, **Performance** ve **Logging** kullandık.
Kullanıcıların register ve login olabileceği bir altyapıyı kurarak, JWT teknikleri ile Token yapısını kurduk.
<br/>
## Projemizin Kaynakları
<br/>

[![C-Sharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Asp-net](https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/apps/aspnet)
[![MSSQL](https://img.shields.io/badge/MSSQL-004880?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server/sql-server-2019?rtc=2)
[![Entity-Framework](https://img.shields.io/badge/Entity%20Framework-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![Autofac](https://img.shields.io/badge/Autofac-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://autofac.org/)
[![Fluent-Validation](https://img.shields.io/badge/Fluent%20Validation-004880?style=for-the-badge&logo=nuget&logoColor=white)](https://fluentvalidation.net/)

## :books:Katmanlar

<br><p align="center"><img width="75%" src="https://i.ibb.co/xH5jqWq/Core-Banner.png"></p><br/>

### Core Katmanı <br/>

* Entitylerimizi ve Dtolarımızı bir interface yardımı ile kontrol altına aldık.
* Tüm proje boyunca bizlere yardımcı olacak (IoC, Message, Result, Security) gibi classlarımızı buraya ekledik.
* ServiceCollection ve User Claimlerimiz için extensionlar yazdık.
* Data Access katmanımız için tüm iş servislerimizde kullanacağımız CRUD işlemlerinin Repositorysini oluşturduk.
* Projemizi dikine kesen CrossCuttingConcernlerimizi buraya ekledik.
* Autofac yardımı ile kullandığımız AOP aspectlerimizi buraya ekledik.

<br><p align="center"><img width="75%" src="https://i.ibb.co/3MwL4gc/Entities-Banner.png"></p><br/>

### Entities Katmanı <br/>
* Projemizde kullandığımız veritabanı tablolarını Concrete klasörü altında topladık.
* Birbiriyle ilişkili olan tablolarımızı ise Dtos altında ihtiyacımıza göre oluşturduk.

<br><p align="center"><img width="75%" src="https://i.ibb.co/VLm3ZGD/Data-Access-Banner.png"></p><br/>

### DataAccess Katmanı <br/>
* Veritabanı ile direk ilişkisi olan bu katmanımız için sadece veritabanına ait işlemler yapıldı.
* CRUD işlemlerimiz direk Core üzerinden geldiği için burada classlarımıza EntityFramework için oluşturudğumuz Repositoryleri kullandık.
* Ana işlemlerimiz dışında ilişkili olan tablolarımıza ait özel sorgularımızı ise buradaki classlarımıza ekledik.

<br><p align="center"><img width="75%" src="https://i.ibb.co/vdnqPgQ/Business-Banner.png"></p><br/>

### Business Katmanı <br/>
* DataAccess katmanına işlemlerimizi göndermeden önce tüm operasyonumuzu bu katmanda dönecek şekilde organize ettik.
* Her bir managerımız üzerinde bulunan metodları Aspectlerin yardımı ile tertemiz bir şekilde yazdık.
* Yaptığımız işlem DataAccess katmanınıa gitmeden önce burada çeşitli kontrollerden geçirmekteyiz.
* CacheAspect sayesinde Get sorgularımızı getirirken tekrar tekrar veritabanımıza bir yoğunluk taşımadan direk Cache üzerinden datamıza ulaşmaktayız.
* ValidationAspect sayesinde kullanıcının yanlış veya eksik veri girişlerine karşın veritabanımızı hem korumaktayız hem de kontrol yükünü üstünden almaktayız.
* PerformanceAspect sayesinde methodlarımızın çalışma hızını takip ederek, olası bir yavaşlıkta bildirim alabilmekteyiz.
* LogAspect sayesinde yapılan işlem hakkında ister bir dosyaya ister database üzerine log alabilmekteyiz.
* TransactionalAspect sayesinde kritik işlemlerimiz için yapılan işlemi bir hata oluşması durumunda geri alabilmekteyiz.

