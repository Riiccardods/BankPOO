namespace TESTE
{
    internal class Program
    {
        static void Main(string[] args) 
        {


            class ContaBancaria

            // Atributos
            public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtor
        public ContaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        // Método para realizar um depósito
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor} realizado. Novo saldo: {Saldo}");
        }

        // Método para realizar um saque
        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado. Novo saldo: {Saldo}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
        }

            }


    }
}
