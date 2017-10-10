using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HTMLSouceGetter
{
	class Program
	{
		static void Main()
		{
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string inputedUrl = Console.ReadLine();
			string targetSource = webClient.DownloadString(inputedUrl);
			Console.Write(targetSource);
			Console.ReadKey();
			
		}
	}
}
