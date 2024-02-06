//Degiskenler();

using Business.Concrete;
using Entities.Concrete;

Vatandas vatandas = new Vatandas();

SelamVer("Asım");
Topla(3,5);

// Diziler /Arrays

string[] ogrenciler = new string[3];
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Berkay";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler = new[] {"Ankara","İstanbul","İzmir"};
string[] sehirler2 = new[] {"Bursa","Antalya","Diyarbakır"};
sehirler2 = sehirler;
sehirler[0] = "Adana";
Console.WriteLine(sehirler2[0]);

foreach (var sehir in sehirler)
    Console.WriteLine(sehir);


List<string> yeniSehirler = new List<string>{"Ankara","İstanbul","İzmir"};
yeniSehirler.Add("Trabzon");

foreach (var sehir in yeniSehirler)
    Console.WriteLine(sehir);



Person person= new Person() {FirstName="ASIM",LastName="MUTLU",DateOfBirthYear=2001,NationalIdentity=1234};

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);

Console.ReadLine();

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba "+isim);
}

static int Topla(int sayi1=5,int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : "+sonuc);
    return sonuc;
}

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //db den gelir.
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Asım";
    string soyad = "Mutlu";
    int dogumYili = 2001;
    long tcNo = 12345678910;

    Console.WriteLine(tutar * 1.18);
}

public class Vatandas
{
    // Pascal casing
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}

