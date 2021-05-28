using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace Task_8
{
    static class Program
    {
        private static ITelegramBotClient _botClient;
        static void Main()
        {
            _botClient = new TelegramBotClient("1756566198:AAFa6eNPCqySAdhIfH9vnW7-INbwyDjw67s")
                {Timeout = TimeSpan.FromSeconds(10)};
            var me = _botClient.GetMeAsync().Result;
            
            Console.WriteLine($"Bot id: {me.Id} Bot Name: {me.FirstName}");

            _botClient.OnMessage += Bot_OnMessage;
            _botClient.StartReceiving();
            Console.ReadKey();
        }
        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var   type = e.Message?.Document?.FileName;
            type = type?.Substring(type.LastIndexOf('.') + 1);

            var text = e.Message?.Text;
            var textType = e.Message?.Type;
            // var message = Translator.Translate(text);

          var  result = text == null ? $"Ձեր ուղարկած ֆայլի տիպը: \t {type}" : $"Ձեր ուղարկած ֆայլի տիպը: \t {textType} \n \n Դուք գրել եք: \n  {text}";
          
            Console.WriteLine(type);
            Console.WriteLine($"recived text message '{text}' in Chat '{e.Message?.Chat.Id}'");

            await _botClient.SendTextMessageAsync(
                chatId: e.Message?.Chat,
                text: result
            ).ConfigureAwait(false);
        }
    }
}