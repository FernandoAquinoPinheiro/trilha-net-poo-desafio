namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone()
        {
            
        }
        public Iphone(string numero, string modelo, string imei, int memoria) : base( numero, modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"nstalando aplicativo \"{nomeApp}\" no Iphone.");
        }
    }
}