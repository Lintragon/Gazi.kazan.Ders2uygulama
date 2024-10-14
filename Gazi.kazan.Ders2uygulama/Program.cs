using System.Security;

namespace Gazi.kazan.Ders2uygulama
{
    internal class Program
    {
        static int sayi = 5;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ////değişkenler-Veri Yapıları
            ////console:WeitLine("gazi")
            ////console:WeitLine("Üniversitesi")
            //byte a; //Veri tipi byte ismi a
            //byte b;
            //a = 10;// değişenlere değer ataması
            //b = 20;
            //byte c = 30;
            byte a = 30, b;
            //buraya kadar a ın değeri 30
            a = 250; //Burda a nın değeri 100
            b = 250;
            int v = a * b;
            Console.WriteLine(v);

            const byte  d = 30; // Const"Sabit değer" sonradan değiştirilemez. 
            Console.WriteLine(a); //değişkein "a"nın değerini göster
            Console.WriteLine("a"); // "a" yazısını göster  göster
            //byte yas;
            //Console.WriteLine(yas); hatalı kullanımdır değer atanmadan ekrana yazdırılamaz
            Console.ReadKey();
            //byte 1yas;
            //int* yas; şeklinde kullanılamaz sayı veya özel değerle başlamaz "_" ile kullanılır
            //1 bit = 0 veya 1
            //8 bit = 1 byte
            //1 Kilo byte(KB) = 1024byte
            //1 Mega byte(MG) = 1024KB
            //1 Giga byte(GB) = 1024MB
            //1 Tera byte(TB) = 1024
            //byte a = 256; //overflow hata verir
            //byte a = 250; //doğru
            //byte c = 0 ; //doğru
            int sayi = 202000232; //2 Milyar civarını tutabilir
            Console.WriteLine(sayi);
            //sbyte(8 bit) -128 +128 arasında yer alır
            //short(16 bit) -32000küsür ilê +32000 arası
            //ushort(16 bit) 0 dan 62000 arası

            //byte yas;şeklinde yazılırsa uygulama çalışmaz
            //float
            //float k = 3.15f; doğru kullanım syntax e uygun
            //float k = 3.15;  yanlış yazım
            //double 64 bitlik reel değer saklamak için kullanılır
            //decimal 128 bit
            //decimal a =2m; m getirilmeli
            //byte sayi =15,3f; böyle atama olmamaz
            //var sayi = 10.20m
            //var sayi = 10.20f yapsakta hata olmaz değer ataması yapılabilir "var" değişken atama tipi genel tanımlama kullanılır çevirii
            //var sayi =5.000; implicit (veri tipinin açık olmadığı versiyonlarda kullanılır)
            //double number = 5.25; Exlicit (Veri tipinin açıkça belirtildiği durum)
            //bool : true false ataması bool sonuc = false;
            //char tek bir karakter kullanmak içim kullanılır
            //char c='a'; tek tırnak içinde kullanılır sytex i öyle
            char c = 'a';
            //char a='/u213'; Uniode saklamak olarak geçiyor
            //string veri tipi metinsel veri tipi Console.WriteLine("asdasdawdsdaw") gii
            //string isim ="Ahmet";
            //string soyad ="kızıl"; "" içi türkçe olabilir ama değişken olamaz
        }
    }
}
