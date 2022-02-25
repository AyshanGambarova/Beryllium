using Beryillium.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryillium.DAL
{
    public class ConnectToDb:DbContext
    {
        public ConnectToDb(DbContextOptions<ConnectToDb> options) : base(options)
        { }
        public DbSet<Slider> SLiders { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Feature> Features{ get; set; }
    }
}
