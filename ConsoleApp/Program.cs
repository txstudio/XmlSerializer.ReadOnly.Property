using DataContract;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order _order;

            _order = new Order();
            _order.OrderNo = "20180305-0001";
            _order.OrderDateTimeUtc = DateTime.UtcNow;


            //use Json.NET
            Console.WriteLine("Json.NET output");
            Console.WriteLine("---------------------");
            Console.WriteLine(ToJson(_order));
            Console.WriteLine("---------------------");
            Console.WriteLine();

            //use XmlSerializer
            Console.WriteLine("XML output");
            Console.WriteLine("---------------------");
            Console.WriteLine(ToXml(_order));
            Console.WriteLine("---------------------");
            Console.WriteLine();
            

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }

        
        static string ToJson(Order order)
        {
            var _json = JsonConvert.SerializeObject(order);
            var _obj = JObject.Parse(_json);

            return _obj.ToString();
        }

        static string ToXml(Order order)
        {
            var _serializer = new XmlSerializer(typeof(Order));
            var _builder = new StringBuilder();

            using (var _writer = new StringWriter(_builder))
            {
                _serializer.Serialize(_writer, order);
            }

            return _builder.ToString();
        }
    }
}
