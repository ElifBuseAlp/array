// --------------------------array----------------------------

//----------- array tanımlama----

string[] renkler = new string[5];

string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

int[] dizi;
dizi = new int[5];

//-----arraylere değer atama ve erişim---

//index 0'dan başlar

renkler[0] = "mavi";

dizi[3] = 5;

Console.WriteLine(renkler[0]);
Console.WriteLine(dizi[3]);
Console.WriteLine(hayvanlar[2]);

//----döngülerle array kullanımı-----

//klayveden girilen n tane sayının ortalamasını alan program

Console.WriteLine("lütfen dizinin eleman sayısını giriniz: ");

int diziuzunlugu = Convert.ToInt32(Console.ReadLine());  //konsoldan sayı aldık

int[] sayidizisi = new int[diziuzunlugu]; // dizi uzunluğunda bir sayı dizisi oluşturduk

for (int i = 0; i < diziuzunlugu; i++) //index 0 dan başladığı için i <= kullanılmaz 1 küçük sayı olmalı index.
{
    Console.WriteLine("lütfen {0}. sayısını giriniz:",i+1);
    sayidizisi[i] = Convert.ToInt32(Console.ReadLine());
}

int toplam = 0;

foreach (var sayi in sayidizisi)

    toplam = sayi + toplam;
Console.WriteLine("Ortalama: " + toplam/diziuzunlugu);



int[] sayisayi = new int[20]; // 20 elemanlı bir array oluştu

int toplamm = 0;

for (int i = 0; i < sayisayi.Length; i++)
{
    Console.Write("lütfen {0}. elemanı girin: ", i+1);
    sayisayi[i] = Convert.ToInt32(Console.ReadLine());
    toplamm = toplamm + sayisayi[i];
    
}

double ort = toplam / 20 ; 
Console.WriteLine("Ortalama: " + ort);



Console.ReadLine();




