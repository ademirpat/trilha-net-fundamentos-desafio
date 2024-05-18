using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO!!!!!!!!!!*
      
            Console.WriteLine("Digite a placa do veículo para estacionar:");

             string placa = Console.ReadLine();

            // Adicionar a placa à lista de veículos
            veiculos.Add(placa);

            // Informar que o veículo foi adicionado com sucesso
            Console.WriteLine("Veículo adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            
            // Solicitar que o usuário digite a placa do veículo para remover
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verificar se o veículo está estacionado no estacionamento
            if (veiculos.Contains(placa))
            {
  
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO!!!!!!!!*
            //string placa = "";
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = int.Parse(Console.ReadLine());

            // Calcular o valor a ser pago
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            // Remover a placa da lista de veículos
            veiculos.Remove(placa);

            // Informar o valor a ser pago e que o veículo foi removido
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }

            // Verifica se o veículo existe
        
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                  int horas = int.Parse(Console.ReadLine());
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTADO!!!!!!*
                  // Verificar se o veículo está estacionado no estacionamento
            if (veiculos.Contains(placa))
            {
                // Solicitar que o usuário digite a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int hor = int.Parse(Console.ReadLine());

                // Calcular o valor a ser pago
                decimal valorTotal = precoInicial + (precoPorHora * hor);
              
                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTADO!!!!!!*

                   veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        }
            public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO!!!!!!*
                 foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
    
  }

