//Degiskenler();

Vatandas vatandas = new Vatandas();

Console.ReadLine();

static void Degiskenler()
{
    string mesaj = "Merhaba";
    double tutar = 100000; //db den gelir.
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Engin";
    string soyad = "Demiroğ";
    int dogumYili = 1985;
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