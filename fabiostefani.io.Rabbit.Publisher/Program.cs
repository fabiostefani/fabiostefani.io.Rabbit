using Contratos;
using System;

namespace fabiostefani.io.Rabbit.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBusConfig.Configure();

            Console.WriteLine("Digite a tecla para adicionar na fila ou 0 para sair");
            var endpoint = MessageBusConfig.BusControl.GetSendEndpoint(new Uri("rabbitmq://localhost/checkin")).Result;

            do
            {
                var tecla = Console.ReadKey().KeyChar;
                Console.WriteLine();
                        endpoint.Send<ProcIntegracaoDto>(new
                        {
                            CodigoIntegracao = tecla
                        });
                
                
            } while (true);

            Console.ReadKey();
        }
    }
}
