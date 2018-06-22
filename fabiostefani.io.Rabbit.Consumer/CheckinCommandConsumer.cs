using Contratos;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.Rabbit.Consumer
{
    public class CheckinCommandConsumer : IConsumer<ProcIntegracaoDto>
    {
        public Task Consume(ConsumeContext<ProcIntegracaoDto> context)
        {
            var command = context.Message;

            Console.WriteLine("Consuming CheckinCommand " + command.CodigoIntegracao);
            
            return Task.FromResult(0);
        }
    }
}
