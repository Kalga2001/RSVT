using Interview.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Interview.BLL
{
    public class StatisticService:IStatisticService
    {
        private readonly TestDbContext _context;
        public StatisticService(TestDbContext context)
        {
            _context = context;
        }

        public int GetUsersCount(Status status)
        {
            var users = _context.Users.ToListAsync();
            int count = 0;

            if(status.Equals(Status.Yes))
            {
                count=_context.Users.Where(e => e.Status == Status.Yes).Count();
            }

             if(status.Equals(Status.No))
             {
                count = _context.Users.Where(e => e.Status == Status.No).Count();
             }

             if (status.Equals(Status.SureNo))
             {
                count = _context.Users.Where(e => e.Status == Status.SureNo).Count();
             }

            return count;

        }

    }
}
