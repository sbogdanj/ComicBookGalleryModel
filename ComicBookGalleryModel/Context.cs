using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComicBookGalleryModel.Models;
using Microsoft.EntityFrameworkCore;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        public DbSet<ComicBook> ComicBooks { get; set;}
    }
}
