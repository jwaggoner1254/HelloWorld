using HWLib.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HWLib.Configuration {
  public class MessageLogConfig : IEntityTypeConfiguration<MessageLog> {
    public void Configure(EntityTypeBuilder<MessageLog> builder) {
      builder.Property(e => e.MessageText).HasColumnType("varchar(50)");
    }
  }
}