class dusman
{
    public int saldir_veya_sifa;
    public int hasar;
    public int can=100;
    public string isim = "Örümcek";
   
}
class oyuncu
{
    public int hasar;
    public int can = 100;
    public string isim = "Furkan";

}

class Program
{
    static void Main(string[] args)
    {
        
        Random rastgele_hasar = new Random();
        Random saldirveyasifa= new Random();
        Random sifabuyusu = new Random();
        dusman dusman1 = new dusman();
        oyuncu furkan = new oyuncu();
        while (dusman1.can>0 && furkan.can>0)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            furkan.hasar = rastgele_hasar.Next(14,17);
            dusman1.hasar = rastgele_hasar.Next(14, 17);
      dusman1.saldir_veya_sifa = saldirveyasifa.Next(0,2);
            
      Console.WriteLine(furkan.isim+" can:"+furkan.can);
      Console.WriteLine(dusman1.isim + " can:" + dusman1.can);
      Console.WriteLine("[1]-Saldır | [2]-Şifa");
      Console.Write("Seçiminiz nedir:");
      int secim=Convert.ToInt32(Console.ReadLine()); 
      if (secim==1)
 {
 dusman1.can -= furkan.hasar;
 Console.ForegroundColor = ConsoleColor.Green;
 Console.WriteLine("Düşmana vuruldu! Verilen hasar:"+furkan.hasar);
 }
 if (secim==2)
 {
 int buyumiktari = sifabuyusu.Next(10, 20);
 furkan.can += buyumiktari;
 Console.ForegroundColor = ConsoleColor.Yellow;
 Console.WriteLine("Şifa büyüsü kullanıldı! Sağlanan şifa:"+buyumiktari);
 }
 if (dusman1.can <= 0)
 {
 Console.ForegroundColor = ConsoleColor.Green;
 Console.WriteLine("Tebrikler! " + dusman1.isim + "'i yendin");
 break;
 }
 if (dusman1.saldir_veya_sifa == 0)
 {
 furkan.can -= dusman1.hasar;
 Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("Düşman sana vurdu! Verilen hasar:"+dusman1.hasar);
 }
 if (dusman1.saldir_veya_sifa == 1)
 {
 int buyumiktari = sifabuyusu.Next(10, 20);
 dusman1.can += buyumiktari;
 Console.ForegroundColor = ConsoleColor.DarkYellow;
 Console.WriteLine("Düşman şifa büyüsünü kullandı! Sağlanan şifa:" + buyumiktari);
 }
 if (furkan.can <= 0)
 {
 Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("Maalesef kaybettin.");
 break;
 }}}}
