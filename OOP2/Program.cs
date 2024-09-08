using OOP2;

internal class Program
{
    private static void Main(string[] args)
    {
        //kübra ünsal
        GercekMusteri musteri1 = new GercekMusteri();
        musteri1.MusteriNo = "12345";
        musteri1.Adi = "Kübra";
        musteri1.Soyadi = "Ünsal";
        musteri1.TcNo = "1234567890";
        musteri1.Id = 1;

        //kadloma.io

        TuzelMusteri musteri2 = new TuzelMusteri();
        musteri2.MusteriNo = "2";
        musteri2.VergiNo = "54321";
        musteri2.SirketAdi = "Kodlama.io";
        musteri2.VergiNo = "123456789";

        //Gerçek Müşteri - Tüzel Müşteri
        //ASOLID

        Musteri musteri3 = new GercekMusteri();
        Musteri musteri4 = new TuzelMusteri();

        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Ekle(musteri2);


    }
}