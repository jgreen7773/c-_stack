using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Dojo_Survey.Models;

namespace Dojo_Survey
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            // List<SurveyUser> users = new List<SurveyUser>();
            // users.Add(new SurveyUser(){
            //     Name = "Jambo",
            //     Location = "Seattle",
            //     Language = "ReactJS",
            //     Comments = "This is my comment",
            // });
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}