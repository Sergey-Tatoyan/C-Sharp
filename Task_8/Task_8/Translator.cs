using System;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Task_8
{
    public class Translation
    {
        public string Lang { get; set; }
        public string [] Message { get; set; }
    }

    public class Translator
    {
        public static string Translate(string message)
        {
            using (var wb = new WebClient())
            {
                var reqData = new NameValueCollection();
                reqData["key"] = "trnsl.1.1.20151224T055717Z.6229809acdf07b74.5d473b9abe91234a4778085591e7124d65d75a75";
                reqData["text"] = message; // text to translate
                reqData["lang"] = "hy"; // target language
                try
                {
                    var response = wb.UploadValues("https://translate.yandex.net/api/v1.5/tr.json/translate", "POST",
                        reqData);
                    string responseInString = Encoding.UTF8.GetString(response);
            
                    var rootObject = JsonConvert.DeserializeObject<Translation>(responseInString);
                    Console.WriteLine($"Original text: {reqData["text"]}\n" +
                                      $"Translated text: {rootObject.Message[0]}\n" +
                                      $"Lang: {rootObject.Lang}");
            
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR!!! " + ex.Message);
                    throw;
                }
            }
            return message;
        }
    }
}
