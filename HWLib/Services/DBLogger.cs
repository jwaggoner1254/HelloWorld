using System;
using HWLib.Entities;
using HWLib.Interfaces;
using Microsoft.Extensions.Configuration;

namespace HWLib.Services {
  public class DBLogger : IMessageLogger {

    private HWContext _HWContext;
    private IConfiguration _configuration;

    public DBLogger(IConfiguration configuration) {
      _configuration = configuration;
      _HWContext = new HWContext(_configuration);
    }

    public bool SaveMessage(string message) {
      _HWContext.MessageLog.Add(new MessageLog { MessageText = message, AddedDate = DateTime.Now });
      _HWContext.SaveChangesAsync();
      return true;
  }

}
}
