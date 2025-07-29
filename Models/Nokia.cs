namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia()
        {
            
        }
       public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado.");
        }
    }
}