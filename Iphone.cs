using DesafioPOO.Models;
namespace DesafioPOO.Models
{
    // IMPLEMENTADO !!
    public class iPhone : Smartphone
    {
        //IMPLEMENTADO
        public iPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone.");
        }
    }
}
