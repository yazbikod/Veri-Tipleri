// Veri Tipleri

// BYTE Veri Tipi :     // 0 - 255 arası Tam Sayılar 1 Kb yer kaplar.
byte birinci = 25;
Console.WriteLine("Byte Verimiz : " + birinci);
Console.WriteLine();     // Bir Satır Boşluk Bıraktık
byte minDeger = byte.MinValue;
byte maxDeger = byte.MaxValue;
Console.WriteLine("En küçük Byte değeri : " + minDeger);
Console.WriteLine("En büyük Byte değeri : " + maxDeger);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// SHORT Veri Tİpi:      // 32767, -32767 arası deger alır. 2 KB yer kaplar.
short deger = -456;
Console.WriteLine("short sayı verimiz : " + deger);
short minDeger1 = short.MinValue;
Console.WriteLine("En küçük Short değeri : " + minDeger1);
short maxDeger2 = short.MaxValue;
Console.WriteLine("En büyük Short değeri : " + maxDeger2);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// INT INTEGER Veri Tİpi:       // +2147483648 -2147483648 arası deger alır 4 Kb yer kaplar.
int sayi = 321656314;
Console.WriteLine("int sayı verimiz : " + sayi);
int minndeger = int.MinValue;
int maxndeger = int.MaxValue;
Console.WriteLine("En küçük Int değeri : " + minndeger);
Console.WriteLine("En büyük Int değeri : " + maxndeger);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// LONG Veri Tipi :     // 18 Haneli deger alır. 8Kb yer kaplar.
long tc = 13461478425;
Console.WriteLine("Long Verimiz : " + tc);
long minxdeger = long.MinValue;
long maxxdeger = long.MaxValue;
Console.WriteLine("En küçük Long değeri : " + minxdeger);
Console.WriteLine("En büyük Long değeri : " + maxxdeger);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// FLOAT Veri Tipi :        // 7 basamağa kadar sayıları tutar. 2 KB yer kaplar.
float ondaliklisayi = 28.35F;
Console.WriteLine("Float Ondalıklı Sayı Verimiz : " + ondaliklisayi);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// DOUBLE Veri Tipi       // 14 basamağa kadar sayıları tutar. 4 KB yer kaplar.

double ondaliklisayi2 = 54361685465.32D;
double ondaliklisayi3 = 32156748466585.548;
Console.WriteLine(ondaliklisayi2);
Console.WriteLine(ondaliklisayi3);
Console.WriteLine("En küçük double değeri : " + double.MinValue);
Console.WriteLine("En büyük double değeri : " + double.MaxValue);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// CHAR Veri Tipi :         // Tek bir karakteri tutar. Harf tek tırnak içine yazılır. 1 Kb yer kaplar.

char karakter = 'S';
Console.WriteLine("Tek bir char karakter ataması : " + karakter);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// STRING Veri Tipi :       // Çift Tırnak içine metin yazılır. Sınırsız yer kaplar.

string karsilama = "Merhaba Arkadaşlar, Web Siteme Hoşgeldiniz!!!";
Console.WriteLine(karsilama);
string isim = "Benim adım : Murat Han ";
Console.WriteLine(isim);
Console.WriteLine("Lütfen Yaşınızı Giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// BOOL Veri Tipi :       // True ya da False değerlerini tutar.

bool sonuc = yas > 18;
Console.WriteLine("18 Yaşından büyüğüm : " + sonuc);

Console.WriteLine();     // Bir Satır Boşluk Bıraktık

// OBJECT Veri Tipi :       // Veri tiplerini atasıdır. Tüm veri tiplerini tutar.

object a = 654654;
object b = 1654.65;
object c = "merhaba";
object d = true;
object e = 'S';

Console.WriteLine("Object ile kayıt edilmiş veri tipleri : " + a);
Console.WriteLine("Object ile kayıt edilmiş veri tipleri : " + b);
Console.WriteLine("Object ile kayıt edilmiş veri tipleri : " + c);
Console.WriteLine("Object ile kayıt edilmiş veri tipleri : " + d);
Console.WriteLine("Object ile kayıt edilmiş veri tipleri : " + e);
