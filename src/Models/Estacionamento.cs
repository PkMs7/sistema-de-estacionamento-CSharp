namespace sistema_de_estacionamento_CSharp.src.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> carros = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora){

            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;

        }

        public void AdicionarVeiculo(){

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            carros.Add(Console.ReadLine());

        }

        public void RemoverVeiculo(){

            ListarVeiculos();

            Console.WriteLine("\nDigite a placa do veículo para remover da lista:");
            string placa = Console.ReadLine();

            if (carros.Any(x => x.ToUpper() == placa.ToUpper())){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                decimal valor = CalcularValorEstacionamento(precoInicial, precoPorHora, horas);

                Console.WriteLine($"O valor a ser pago pelo cliente é: {valor:C}\n");
                Console.WriteLine($"Pressione qualquer tecla para efetivar a remoção do veículo {placa}");
                Console.ReadLine();
                carros.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido com sucesso.");

            } else {
                Console.WriteLine("Desculpe, esse veiculo não está cadastrado aqui.");
            }

        }

        public void ListarVeiculos(){

            if (carros.Any()) {

                Console.WriteLine("Os veículos cadastrados no sistema são:");

                foreach(string item in carros){
                    Console.WriteLine(item);
                }

            } else {

               Console.WriteLine("Não existem veículos estacionados no momento.");

            }


        }

        public decimal CalcularValorEstacionamento(decimal precoInicial, decimal precoPorHora, int horas){

            decimal valorTotal = precoInicial + (precoPorHora * horas);

            return valorTotal;

        }


    }
}