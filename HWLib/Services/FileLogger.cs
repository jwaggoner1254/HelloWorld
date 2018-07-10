using System;
using HWLib.Entities;
using HWLib.Interfaces;
using Microsoft.Extensions.Configuration;

namespace HWLib.Services {
  public class FileLogger : IMessageLogger {

    private IConfiguration _configuration;

    public FileLogger(IConfiguration configuration) {
      _configuration = configuration;
    }

    public bool SaveMessage(string message) {
       // Save to File
      return true;
  }

}
}
