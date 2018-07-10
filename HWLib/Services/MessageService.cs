using Microsoft.Extensions.Configuration;

namespace HWLib.Services {
  public class MessageService {
    public IConfiguration _configuration { get; }
    public string _loggerType { get; set; }


    public MessageService(IConfiguration configuration) {
      _configuration = configuration;
      _loggerType = _configuration.GetValue<string>("LogType");
    }

    public string CreateMessage() {
      return CreateMessage("Hello World!");
    }

    public string CreateMessage(string message) {

      switch (_loggerType) {
        case "DB":
          var logger = new DBLogger(_configuration);
          logger.SaveMessage(message);
          break;
        case "File":
          //Log to File
          break;
        case "SysEvent ":
          //Log to system event log
          break;
        default:

          // no logging
          break;
      }
      
      return message;
    }

  }
}
