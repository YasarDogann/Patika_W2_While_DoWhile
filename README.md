# Patika Week2 While Döngüsü ile Do-While Döngüsü Arasındaki Fark
Merhaba,
Bu proje C# ile While Döngüsü ve Do-While kullanarak alıştırma için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- `while` ile `Do-While` yapısını ve arasındaki farkı anlamak

## 🚀 While Döngüsü
```csharp
int limite_num = 0, i = 0; //limit ve başlangıç değerlerini tanımladım.
Console.Write("Kaç defa çalıştırmak istediğinizi yazın.");
limite_num = int.Parse(Console.ReadLine()); //klavyeden girilen string değeri tam sayıya çevirdim

while (i <= limite_num)
{
    Console.WriteLine(i + ". Ben Bir Patika'lıyım");
    i++;
}
Console.WriteLine("Negatif değer girdin çalışmadı"); //eğer negatif girilmezse döngüye girmeden kod gösterilcek.


Console.Read();
```

While döngüsün'de uygulamaya kullanıcı negatif bir değer girdiğinde döngüye hiç giremeden alttaki "Negarif değer girdin çalışmadı" yazacak.

## 🚀 Do-While Döngüsü
```csharp
  int limite_num = 0, i = 0;

  Console.Write("Kaç defa çalıştırmak istediğinizi yazın: ");
  limite_num = int.Parse(Console.ReadLine());


  do
  {
      Console.WriteLine(i + ". Ben Bir Patika'lıyım"); //en az 1 kere çalışacak. Negatif olsa bile.
      i++;

  } while (i <= limite_num); // basamak sayısı girilen limit'ten küçük olduğu sürece döngü devam edecek.
                             // false değer döndürdüğünde döngüden çıkacak.

  Console.WriteLine("Biitti"); //false değer gelince ekranda gözüken sonuç.

  Console.Read();
```

Do-while döngüsünde ise kullanıcı negatif bir değer girse bile uygulama 1 kere çalışacak.

## Yorum-Sonuç

Input Değeri	    While Döngüsü Çıktısı	      Do-While Döngüsü Çıktısı
10	              11 defa çıktı	              11 defa çıktı
-5	              Çıktı yok	                  1 defa çıktı
