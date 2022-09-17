namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria;


    // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine($"Seu celular {Modelo} está ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Seu celular {Modelo} está recebendo uma ligação...");
        }

        public void InfoCelular(){
            Console.WriteLine("Informação sobre o celular");
            Console.WriteLine($"Modelo {Modelo}, Número: {Numero}, IMEI: {IMEI}, Memória {Memoria}");  
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}