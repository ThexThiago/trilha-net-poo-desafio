using DesafioPOO;

namespace DesafioPOO.Models;
public class Nokia : Smartphone
{
    //IMPLEMENTADO !!
    public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
    {
        // IMPLEMENTADO !!
    }
    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Nokia.");
    }
}
