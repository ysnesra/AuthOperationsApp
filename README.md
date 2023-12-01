# ⚡Authorization İşlemleri Projesi ⚡

Web sitesi için Kullanıcıların, Yetkilerin ve Grupların olduğu Authorization işlemlerinin planlandığı bir uygulamadır.

Uygulama da; DDD(Domain Dream Development) Tekniği ile Onion Architecture mimarisi kullanılmıştır. CQRS tasarımı ile MediatR kütüphanesini kullandığım .NET 8 MVC Core projesidir.

Veritabanı olarak MsSQL ve ORM Toollarından EF Core , tasarım yaklaşımı olarak da CodeFirst kullanılmıştır.

Proje Docker ortamında Distruburted olarak oluşturulmuştur.


Veritabanı işlemlerini soyutlama ve modülerleştirme için Repository Design Pattern tasarım deseni ve Bağımlılıkları yönetmek için Dependency Injection yapısı kullanılmıştır.

Repository Pattern ile birlikte Dependency Injection kullanmak, bağımlılıkların yönetimini kolaylaştırır ve kodun daha esnek hale gelmesini sağlar.

AutoMapper kütüphanesi kullanılırak farklı veri modeli arasında dönüşüm performanslı hale getirildi.


*****
*-Kullanıcı Anasayfadaki Menüden ayarlamak istediği linke tıklayabilir:

    _⦁	Yetkiler_   -> Yetkiler sayfasına yönlendirilir. Kullanıcı tüm yetkileri görebilir; 
    
                       "Yetkinin bağlı olduğu Grupları" butonu ile istediği yetkiye Grup ekleyip ve kaldırabilir.
                       
                       "Düzenle" butonu ile Yetki ismini değiştirebilir.       

                       
    _⦁	Yetki Grupları_  -> Yetki Grupları sayfasına yönlendirilir. Kullanıcı tüm grupları görebilir; 
    
                       "Grubun Yetkilerini Göster" butonu ile istediği gruba Yetki ekleyip ve kaldırabilir.
                       
                       "Bağlı Kullanıcıları Göster" butonu ile istediği gruba Kullanıcı ekleyip ve kaldırabilir.
                       
                       "Düzenle" butonu ile Grup ismini değiştirebilir.       

    
    _⦁	Kullanıcılar_ -> Kullanıcılar sayfasına yönlendirilir. Tüm Kullanıcılar listelenir; 
    
                       "Kullanıcının Gruplarını Göster" butonu ile istediği kullanıcıya Grup ekleyip ve kaldırabilir.
                       
                       "Düzenle" butonu ile Kullanıcı ismini değiştirebilir.      


*****


 _Anasayfa:_ 
 
 ![1anasayfa](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/1f5e9557-ef84-477c-98bc-0dd7d0017257)


*****

 _Yetkiler Sayfası:_ 

![2Yetkiler](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/edd91495-78b7-4b93-a71d-f38013c1d9d8)


 *****

_Dashboard Yetkisinin Gruplarını Ayarlama Sayfası:_ 

|![3Gruplar](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/5aaeb07c-216d-4166-88b7-ee4ffe56f5e8)
  |![4GruplarAtama](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/39a56af6-73d9-4575-91e7-24d7cebdb1a8)
 |
|--|--|
|  |  |


*****

_Yetki İsmini Güncelleme:_ 

|![5YetkiGüncellme](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/aab91361-e208-4716-aa9c-36fd056152f6)

  |![6GüncelYekiler](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/3e365428-97a7-44f7-9485-b4cb2264c7cd)
 |
|--|--|
|  |  |


*****

 _Yetki Grupları Sayfası:_ 

!![7Yetki Grupları](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/0c082015-1f56-41f7-b1f7-8ebf81f465f8)



 *****


_Raporlama Grubunun Yetkilerini Ayarlama Sayfası:_ 

|![8Roller](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/41aac5c2-b164-4c81-b1ac-a80e49eea07f)

  |![9RolAtama](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/6968374c-189b-4dd8-8234-85dd8df2540f)
 |
|--|--|
|  |  |


 *****

 
_Raporlama Grubunun Kullanıcılarını Ayarlama Sayfası:_ 

|![10Kullanıcılar](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/56949f52-f68a-490d-b90e-625cdea83116)

  |![11KullanıcıAtama](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/02cab629-d5c6-4e3d-abe3-1641d1a73394)
 |
|--|--|
|  |  |

 *****

_Yetki İsmini Güncelleme:_ 

|![12GrupGüncelleme](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/5b853760-067d-4b05-a8fb-95b46e064f9d)

  |![13GüncelGrup](https://github.com/ysnesra/AuthOperationsApp/assets/104023688/a6ac86b5-7b53-4f22-b8bd-b2023a251063)
 |
|--|--|
|  |  |
