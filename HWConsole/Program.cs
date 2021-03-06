﻿using System;
using System.IO;
using HWLib.Services;
using Microsoft.Extensions.Configuration;

namespace HWConsole {
  class Program {

    static void Main(string[] args) {
      
      var di = new DirectoryInfo(".");
      var builder = new ConfigurationBuilder()
        .SetBasePath(Path.Combine(di.FullName))
                     .AddJsonFile("appsettings.json");

      var configuration = builder.Build();


      var MS = new MessageService(configuration);

      Console.WriteLine(MS.CreateMessage());
      //Console.WriteLine(MS.CreateMessage("Test Message"));
      Console.ReadLine();
    }
  }
}
