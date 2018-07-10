using System;
using System.IO;
using System.Reflection;
using HWLib.Configuration;
using HWLib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HWLib {
  class HWContext : DbContext {

    public IConfiguration _configuration { get; }

    public HWContext(IConfiguration configuration) {
      _configuration = configuration;
    }

    public DbSet<MessageLog> MessageLog { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
    }
    protected override void OnModelCreating(ModelBuilder builder) {
      base.OnModelCreating(builder);


      builder.ApplyConfiguration(new MessageLogConfig());
    }

  }
}
