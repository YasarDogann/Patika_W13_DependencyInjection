# Pratik - DependencyInjection 
Merhaba,
Bu proje C# ile Patika+ 13.hafta DependencyInjection  uygulaması için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- MVC Yapısını kullanmak ve anlamak
- ASP.NET Core Kullanmak
- Entity Framework Kullanmak

 
## İstenilen Görev: 
Pratik - Dependency Injection

Aşağıda verilen sınıflar arasında Dependency Injection kullanarak bir örnek oluşturun.

Sınıflar:

   1. TeacherSınıfı

      - Özellikler:

        - `FirstName`: string

        - `LastName`: string

      - Metotlar:

        - `GetInfo()`: Öğretmenin adını ve soyadını döndüren bir metot.

   2. ClassRoom Sınıfı

      - Özellikler:

        - `Teacher`: Ogretmen türünde bir nesne

      - Metotlar:

        - `GetTeacherInfo()`: Öğretmenin bilgilerini döndüren bir metot. Teacher içerisindeki GetInfo()'yu çağırması yeterli.

Görev:

   - `Teacher` ve `Classroom` sınıflarını yazın.

   - `ClassRoom` sınıfının yapıcısına (constructor) `Teacher` sınıfının bir örneğini (instance) parametre olarak geçin. (Constructor Injection)

   - Her iki sınıfın metotlarını kullanarak bir `Classroom` nesnesi oluşturun ve öğretmenin bilgilerini ekrana yazdırın.

NOT: Dependency Injection, bir sınıfın ihtiyaç duyduğu bağımlılıkların dışarıdan verilmesi anlamına gelir. Bu, sınıflar arasındaki bağımlılıkları azaltarak daha esnek bir yapı sağlar.

EK : Ogretmen sınıfı için bir Base Interface oluşturmayı unutmayın. `IOgretmen`

## 📚 NoT: 
 - Entity Framework Kullanmadan basit proje olarak yapıldı

 - Seed Data progra.cs içinde oluşturuldu ve tek bir öğretmen ad soyad bilgisi gözükecektir.
   - ![successed](https://github.com/user-attachments/assets/33b4ae28-b2ee-44a9-a84c-fcdacfb6b137)
   - ![program cs](https://github.com/user-attachments/assets/6f8f1a68-a94a-40a4-a1a5-6ae6ccc5bd06)

   
