using Microsoft.AspNetCore.Mvc;
using Play.Domain;
using Play.Infrastructure;

namespace Play.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MeetingsController : ControllerBase
{
    private readonly MeetingContext _context;

    public MeetingsController(MeetingContext context) {

        _context = context;

        var m1 = new Meeting { Id = Guid.NewGuid(), Title = "Mind Meld", Type = "Engagement"};
        var m2 = new Meeting { Id = Guid.NewGuid(), Title = "Kickoff", Type = "Other"};

        _context.Add(m1);
        _context.Add(m2);
        _context.SaveChanges();
    }
   
    
    

    [HttpGet(Name = "Meetings")]
    public List<Meeting> GetAll()
    {
        return _context.Meetings.ToList();
        
    }


}
