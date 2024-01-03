namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string nomeApp,string numero, string modelo, string imei, int memoria) : base(nomeApp,numero, modelo, imei, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Instalando o aplicativo {nomeApp} na loja de aplicativos do Nokia...");
        }
        
    }
}