namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; }
        public string IMEI { get;  }
        public int Memoria { get;  }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Memoria = memoria;
            IMEI = imei;
            Modelo = modelo;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}