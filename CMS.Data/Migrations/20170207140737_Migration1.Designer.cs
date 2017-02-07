using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CMS.Data;
using CMS.Data.Model.Enum;

namespace CMS.Data.Migrations
{
    [DbContext(typeof(CMSDBContext))]
    [Migration("20170207140737_Migration1")]
    partial class Migration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CMS.Data.Model.Entity.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ArticleType");

                    b.Property<int?>("AuthorId");

                    b.Property<string>("Contents");

                    b.Property<string>("CoverUrl");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDel");

                    b.Property<int>("ReadCount");

                    b.Property<string>("Summary");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("CMS.Data.Model.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("LoginName");

                    b.Property<string>("NickName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CMS.Data.Model.Entity.Article", b =>
                {
                    b.HasOne("CMS.Data.Model.Entity.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");
                });
        }
    }
}
