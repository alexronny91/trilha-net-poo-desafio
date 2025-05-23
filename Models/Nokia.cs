using System.ComponentModel;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no dispositivo {Modelo}, com IMEI {IMEI} e memória RAM de {Memoria}gb");
        }
    }
}
