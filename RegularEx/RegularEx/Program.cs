using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace RegularEx
{
    class Program
    {
        static void OnlyDigits()
        {
            //with length 4
            string str;
            Regex rg = new Regex("^\\d\\d\\d\\d$", RegexOptions.Compiled);
            do
            {
                Console.WriteLine("Your input");
                str = Console.ReadLine();
            }
            while (!rg.IsMatch(str));
            Console.WriteLine("Great!");
        }
        static void DigitsAndSpaces()
        {
            //with lenth 4
            string str;
            Regex rg = new Regex("^\\d\\s*\\d\\s*\\d\\s*\\d\\s*?$", RegexOptions.Compiled);
            do
            {
                Console.WriteLine("Your input");
                str = Console.ReadLine();
            }
            while (!rg.IsMatch(str));
            Console.WriteLine("Great!");
        }
        static void OnlyLetters()
        {
            string str;
            Regex rg = new Regex("[a-z A-Z]", RegexOptions.Compiled);
            do
            {
                Console.WriteLine("Your input");
                str = Console.ReadLine();
            }
            while (!rg.IsMatch(str));
            Console.WriteLine("Great!");
        }
        public static string SendGetRequest(string url)
        {
            try
            {
                ServicePointManager.DefaultConnectionLimit = 10;
                ServicePointManager.Expect100Continue = false;
                ServicePointManager.DnsRefreshTimeout = 1000;
                ServicePointManager.UseNagleAlgorithm = false;

                string response = "";
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.2; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
                request.Timeout = 300000;
                using (var stream = request.GetResponse().GetResponseStream())
                {
                    stream.ReadTimeout = 300000;
                    using (var streamReader = new StreamReader(stream, Encoding.GetEncoding("UTF-8")))
                    {
                        response = streamReader.ReadToEnd();
                    }
                }
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "";

        }
        static void Main(string[] args)
        {
            //OnlyDigits();
            //DigitsAndSpaces();
            //OnlyLetters();
            string s3 = "<li><a href=\"(.*?)\" class=\"db fs16 arian-b\">(.*?)</a><span class=\"fs14\">(.*?)</span></li>";


            string s = SendGetRequest("http://www.armsport.am/hy");
            List<string> list = new List<string>();
            int i = 0;
            MatchCollection titleslinks = Regex.Matches(s, s3, RegexOptions.Singleline);
            foreach (Match x in titleslinks)
            {
                if (i > 1 && i < 20)
                {
                    GroupCollection Group = x.Groups;
                    //url
                    string ss1 = Group[1].Value.Trim();
                    //content
                    string ss2 = Group[2].Value.Trim();
                    //date time
                    string ss3 = Group[3].Value.Trim();
                }
                i++;
            }
        }
    }
}
