using Dashboard.DashboardDomain.Posts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.DataAccess.Configurations
{
    /// <summary>
    /// Конфигурация таблицы Posts.
    /// </summary>
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable(nameof(Post));

            builder.HasKey(p => p.PostId);
            builder.Property(p => p.PostId).ValueGeneratedOnAdd();
        }
    }
}
