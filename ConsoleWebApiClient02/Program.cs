using System;
using System.IO;
using System.Net;

namespace ConsoleWebApiClient02
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string url = string.Format("http://localhost:51062/EnUcuz");
            WebRequest wr = WebRequest.Create(url);
             wr.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)wr.GetResponse();
            using (Stream st = res.GetResponseStream() )
            {
                StreamReader sr = new StreamReader(st);
                string strRes = sr.ReadToEnd();
                sr.Close();
                Product pr = (Product)Newtonsoft.Json.JsonConvert.DeserializeObject(strRes,typeof(Product));

                Console.WriteLine(pr.ProductName);

                Console.ReadKey();

              
            } 



        }


    }
}
