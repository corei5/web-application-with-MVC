using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace web_application_with_MVC.Models
{
    public class web_application_with_MVCMusicStoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public web_application_with_MVCMusicStoreContext() : base("name=web_application_with_MVCMusicStoreContext")
        {
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<MvcMusicStore.Models.Review> Reviews { get; set; }
        public DbSet<MvcMusicStore.Models.Artist> Artists { get; set; }

    }
}
