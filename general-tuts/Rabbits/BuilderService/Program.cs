using System.Text;
using RabbitMQ.Client;
using BuilderService;

Console.WriteLine("Builder Service");

var factory = new ConnectionFactory() { HostName = "localhost" };
using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

channel.QueueDeclare(queue: "hello",
    durable: false,
    exclusive: false,
    autoDelete: false,
    arguments: null);

var rant = new Bogus.DataSets.Rant();
var count = 10;
for (var ctx = 0; ctx < count; ctx++)
{
    var message = new Message
    {
        Id = Guid.NewGuid(),
        Content = rant.Review(),
        Sequence = ctx
    };
    var encodedBytes = Encoding.UTF8.GetBytes(System.Text.Json.JsonSerializer.Serialize(message));
    channel.BasicPublish(exchange: string.Empty,
        routingKey: "hello",
        basicProperties: null,
        body: encodedBytes);
}

