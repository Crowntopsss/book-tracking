using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookTracking.Models;

namespace BookTracking.Data
{
    public class BookTrackingContext : DbContext
    {
        public BookTrackingContext (DbContextOptions<BookTrackingContext> options)
            : base(options)
        {
        }

        public DbSet<BookTracking.Models.Book> Book { get; set; }
    }
}
