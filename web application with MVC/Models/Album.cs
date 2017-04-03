using MvcMusicStore.Models;
using System.Collections.Generic;

namespace web_application_with_MVC.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Title { get; set; }
        public Artist Artist { get; set; }
        public virtual List<Review> Review { get; set; }
    }
}