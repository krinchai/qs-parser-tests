using System;

namespace qs_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var url in new string[] {            
                "http://foo.bar.com/?hello=jeff&hello=tom&hello=joe",
                "http://foo.bar.com/?hello=jeff,tom,joe",
                "http://foo.bar.com/?hello=jeff&tom&joe"
            })
            {
                Console.WriteLine(url);
                var uri = new Uri(url);
                Console.WriteLine(uri.Query);
                var query = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);
                foreach (var kv in query) Console.WriteLine(kv);
            }
        }
    }
}
