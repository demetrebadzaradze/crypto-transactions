using System;
using Solnet.Rpc;

namespace program
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rcpClient = ClientFactory.GetClient(Cluster.DevNet);
            string senderAccount = "MVHw2T74iD8eYT9Qqy6aPo1U6n4nopwvnULeFTK1ifm";
            string reciverAccount = "6NvAyvfggouHR8vht9aHq9tTTUJ5W2LUrAPXUVVzB6zn";
            string mintAddres = "mntmxLRmk2Psn4YjVAWR5vBizuCtSRBYhhWDY2XpeEm";

            var client = rcpClient.GetAccountInfo(reciverAccount);
            var balance = rcpClient.GetBalance(reciverAccount);

            var amount = rcpClient.GetTokenAccountsByOwner(reciverAccount,mintAddres);

            for (int i = 0; i < amount.Result.Value.Count; i++)
            {
                Console.WriteLine(
                    rcpClient.GetTokenAccountBalance(
                        amount.Result.Value[i].PublicKey)
                        .Result
                        .Value
                        .AmountDouble);
            }
        }
    }
}