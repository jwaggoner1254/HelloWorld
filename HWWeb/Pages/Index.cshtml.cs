using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HWLib.Services;
using Microsoft.Extensions.Configuration;

namespace HWWeb.Pages {
  public class IndexModel : PageModel {
    private IConfiguration _configuration;

    public IndexModel(IConfiguration configuration) {
      _configuration = configuration;
    }


    public string PageMessage { get; set; }

    public bool HasPageMessage => PageMessage != null;

    public void OnGet() {
      var MS = new MessageService(_configuration);
      PageMessage = MS.CreateMessage();
    }
  }
}
