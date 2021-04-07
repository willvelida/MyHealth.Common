using Azure.Messaging.ServiceBus;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public class ServiceBusHelpers : IServiceBusHelpers
    {
        public async Task SendMessageToTopic<T>(ServiceBusClient serviceBusClient, string topicName, T messageContent)
        {
            ServiceBusSender sender = serviceBusClient.CreateSender(topicName);
            var messageAsJSONString = JsonConvert.SerializeObject(messageContent);
            await sender.SendMessageAsync(new ServiceBusMessage(messageAsJSONString));
        }
    }
}
