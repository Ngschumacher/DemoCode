using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace AgentDude
{
    public class Program
    {
        public static void Main(string[] args)
        {

			var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
				.UseKestrel(options =>
	            {
			
				})
				.UseUrls("http://agentdude.localhost:50000")
                .Build();

            host.Run();
        }
    }
}
