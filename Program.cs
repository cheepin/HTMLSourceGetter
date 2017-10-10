using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HTMLSouceGetter
{
	class HTMLSouceGetter
	{
		static string GetSource()
		{
			WebClient webClient = new WebClient
			{
				Encoding = Encoding.UTF8
			};
			string inputedUrl = Console.ReadLine();
			string targetSource = webClient.DownloadString(inputedUrl);
			return targetSource;
			
		}
	}
}
