using System.IO;
using HWLib.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestHW {
  [TestClass]
  public class HWUnitTest {
    [TestMethod]
    public void TestMessageService() {
      var di = new DirectoryInfo(".");
      var builder = new ConfigurationBuilder()
        .SetBasePath(Path.Combine(di.FullName))
                     .AddJsonFile("appsettings.json");

      var configuration = builder.Build();


      var MS = new MessageService(configuration);


      var expected = "Hello World!";

      var actual = MS.CreateMessage();

      Equals(expected, actual);


    }

  }
}
