using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Bakery_bot
{
    class Program
    {
        static void Main(string[] args)
        {
            TelegramBotClient client = new TelegramBotClient("6013304748:AAF3OYLJkQTwmrw-XgNHIpY2ZthjbQOQhB4");
            client.StartReceiving(Update,Error);
            Console.ReadLine();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                if (message.Text.ToLower().Contains("Привет"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id,"Hi");
                    return;
                }

            }
        }

        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }
    }
}
