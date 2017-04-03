using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_application_with_MVC.Models;

namespace MvcMusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}