using Azure.Messaging.ServiceBus;
using System.Threading.Tasks;

namespace MyHealth.Common
{
    public interface IServiceBusHelpers
    {
        /// <summary>
        /// Sends a message to a specified topic
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serviceBusClient"></param>
        /// <param name="topicName"></param>
        /// <param name="messageContent"></param>
        /// <returns></returns>
        Task SendMessageToTopic<T>(ServiceBusClient serviceBusClient, string topicName, T messageContent);
    }
}
