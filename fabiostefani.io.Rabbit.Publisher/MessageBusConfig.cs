using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.Rabbit.Publisher
{
    public class MessageBusConfig
    {
        public static IBusControl BusControl { get; set; }
        //public static IList<CheckinResult> CheckinResults { get; set; }

        public static void Configure()
        {
            //CheckinResults = new List<CheckinResult>();

            BusControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Durable = true;
                var host = cfg.Host(new Uri("rabbitmq://localhost"), h =>
                {
                    h.Username("guest");
                    h.Password("guest");
                });

                #region ...

                //cfg.ReceiveEndpoint(host, e => { e.Consumer<CheckinCommandConsumer>(); });
                
                #endregion
            });

            BusControl.Start();
        }
    }
}
