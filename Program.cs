using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "3695", modelo: "Nokia Z1", imei: "165465165161", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
    
        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "13456", modelo: "Iphone 15", imei: "165461321546", memoria: 256);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");
    }
}
// TODO: Realizar os testes com as classes Nokia e Iphone 