using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string url = Console.ReadLine();

            string protocol = string.Empty;
            string server = string.Empty;
            string resource = string.Empty;

            int protocolIndex = url.IndexOf(":");
            int protocolLength = 0;
            for (int i = 0; i < protocolIndex; i++)
            {
                protocolLength += 1;
            }
            protocol = url.Substring(0, protocolLength);

            int serverIndex = url.IndexOf("/", protocolIndex + 3);
            int serverLength = 0;
            for (int i = protocolIndex + 3; i < serverIndex; i++)
            {
                serverLength += 1;
            }
            server = url.Substring(protocolIndex + 3, serverLength);

            int resourceLength = 0;
            for (int i = serverIndex; i < url.Length; i++)
            {
                resourceLength += 1;
            }
            resource = url.Substring(serverIndex, resourceLength);
            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
        }
    }
}
