namespace DesafioPOO.Models
{
    // Implementado para Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Implementado o método "InstalarAplicativo"

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o {nomeApp} no Iphone.");
        }
    }
}