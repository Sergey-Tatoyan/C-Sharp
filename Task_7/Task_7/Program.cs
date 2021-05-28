using System;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
  '@Id': 1,
  'Email': 'sergey@example.com',
  'Active': true,
  'CreatedDate': '2013-01-20T00:00:00Z',
  'Roles': [
    'User',
    'Admin'
  ],
  'Team': {
    '@Id': 2,
    'Name': 'Sergey',
    'Description': 'Hello World.'
  }
}";
            XNode node = JsonConvert.DeserializeXNode(json, "Root");

            if (node != null) Console.WriteLine(node.ToString());
        }
    }
}