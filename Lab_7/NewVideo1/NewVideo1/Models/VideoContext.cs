using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NewVideo1.Models
{
    public class VideoContext : DbContext
    {
        public DbSet<VideoModel> Videos { get; set; }
    }
}