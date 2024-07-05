using RabbitMQ.Client;
using System;
using System.Text;

class Send {
    public static void Main() {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel()) {
            channel.QueueDeclare(queue: "hello",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

            Console.WriteLine("Digite sua mensagem e aparte <ENTER>");

            string mensagem = Console.ReadLine();

            if (mensagem == "") {
                return;
            }

            //string message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(mensagem);

            channel.BasicPublish(exchange: "",
                                 routingKey: "hello",
                                 basicProperties: null,
                                 body: body);
            Console.WriteLine(" [x] Sent {0}", mensagem);
        }

        Console.WriteLine(" Press [enter] to exit.");
        Console.ReadLine();
    }
}
