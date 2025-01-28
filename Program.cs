using System;
using Solnet.Rpc;

namespace program
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rcpClient = ClientFactory.GetClient(Cluster.DevNet);
            string publicAddres = "MVHw2T74iD8eYT9Qqy6aPo1U6n4nopwvnULeFTK1ifm";
            string mintAddres = "mntmxLRmk2Psn4YjVAWR5vBizuCtSRBYhhWDY2XpeEm";

            var client = rcpClient.GetAccountInfo(publicAddres);
            var balance = rcpClient.GetBalance(publicAddres);

            var amount = rcpClient.GetTokenAccountBalance(mintAddres);

            Console.WriteLine(amount.WasSuccessful );
            Console.WriteLine(amount.WasHttpRequestSuccessful);
            Console.WriteLine(amount.WasRequestSuccessfullyHandled);
            Console.WriteLine(amount.RawRpcRequest);
            Console.WriteLine(amount.RawRpcResponse);
            Console.WriteLine(amount.Result.Value);
        }
    }
}