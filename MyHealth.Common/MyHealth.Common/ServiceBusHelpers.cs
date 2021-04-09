using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public class ServiceBusHelpers : IServiceBusHelpers
    {
        private readonly ServiceBusClient _serviceBusClient;

        public ServiceBusHelpers(string connectionString)
        {
            _serviceBusClient = new ServiceBusClient(connectionString);
        }

        public async Task SendMessageToTopic<T>(string topicName, T messageContent)
        {
            ServiceBusSender sender = _serviceBusClient.CreateSender(topicName);
            var messageAsJSONString = JsonConvert.SerializeObject(messageContent);
            await sender.SendMessageAsync(new ServiceBusMessage(messageAsJSONString));
        }
    }
}
