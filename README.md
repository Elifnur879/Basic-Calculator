# Basic Calculator

C# öğrenirken yaptığım ilk konsol uygulaması. Temel matematik işlemlerini yapan, kullanıcı dostu bir hesap makinesi.

## Özellikler

- Dört işlem: toplama, çıkarma, çarpma, bölme
- Mod alma (%) ve üs alma (^)
- Sıfıra bölme hatasını güvenli şekilde karşılama
- Geçersiz işlem girişini kontrol etme
- Art arda birden fazla işlem yapabilme
- Yapılan tüm işlemlerin geçmişini gösterme

## Nasıl çalışır?

Program, kullanıcıdan iki sayı ve bir işlem (+, -, *, /, %, ^) ister, sonucu hesaplayıp ekrana yazdırır. İşlem bittikten sonra kullanıcıya başka bir hesaplama yapmak isteyip istemediği sorulur. Kullanıcı "n" (hayır) dediğinde, program o oturumda yapılan tüm işlemlerin bir özetini gösterir.

## Kullanılan teknolojiler

- C#
- .NET

## Öğrenme notları

Bu proje ile şunları öğrendim:
- Kullanıcıdan konsol üzerinden veri alma ve tür dönüştürme (`Convert.ToDouble`)
- Koşullu ifadeler (`if / else if / else`)
- Döngüler (`while`)
- Listeler (`List<string>`)
- Hata durumlarını yönetme

## Sıradaki adımlar

- Windows Forms ile görsel bir arayüze dönüştürme
