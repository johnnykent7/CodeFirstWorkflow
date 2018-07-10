using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWorkflow
{
    public class PlutoContext : DbContext
    {
        public DbSet<Video> GetVideos { get; set; }
        public DbSet<Genre> GetGenres { get; set; }
        public DbSet<VideoGenre> GetVideoGenres { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
