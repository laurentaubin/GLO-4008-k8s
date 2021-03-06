using Microsoft.EntityFrameworkCore;

namespace glo4008.Feedback.Model
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext (DbContextOptions<FeedbackContext> options)
            : base(options)
        {
        }

        public DbSet<Feedback> Feedback { get; set; }   
    }
}