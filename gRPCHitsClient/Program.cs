using System;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace gRPCHitsClient
{
    class Program
    {
        private const string SERVER_GRPC = "https://localhost:5001";

        public static async Task Main()
        {
            if (!SERVER_GRPC.StartsWith("https"))
            {
                AppContext.SetSwitch(
                    "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            }

            var channel = GrpcChannel.ForAddress(SERVER_GRPC);
            var client = new CounterSvc.CounterSvcClient(channel);

            while (true)
            {
                var result = await client.GenerateValueAsync(
                    new CounterRequest()
                    {
                        Name = "Lucas"
                    });

                Console.WriteLine(
                    $"| Message: {result.Message} " +
                    $"| Current Value: {result.CurrentValue} " +
                    $"| Local: {result.LocalSvc} " +
                    $"| Target Framework: {result.TargetFramework} |");

                Console.ReadKey();
            }
        }
    }
}