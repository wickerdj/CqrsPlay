using Play.Domain;
using Microsoft.EntityFrameworkCore;

namespace Play.Infrastructure;
public class MeetingContext: DbContext {
    public MeetingContext()
    {
    }

    public MeetingContext(DbContextOptions<MeetingContext> options): base(options) { }
    
    public DbSet<Meeting> Meetings { get; set; }
}
