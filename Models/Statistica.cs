using System.Transactions;

namespace Interview.Models
{
    public class Statistica
    {
        public int GetCountYes()
        {
          
            int yes = 0;
            using (var _context = new TestDbContext())
            {
                yes = (from c in _context.Users select c).Where(t=>t.Status.CompareTo(t.Status) == 1).Count();
            }
            return yes;
        }

        //public int GetCountNo()
        //{
        //    int no = 0;
        //    using (var _context = new TestDbContext())
        //    {
        //        no = (from c in _context.Users select c).Where(t => t.Status.CompareTo(t.Status) == 2).Count();
        //    }
        //    return no;
        //}

        //public  int GetCountNoSure()
        //{

        //    int sureNo = 0;
        //    using (var _context = new TestDbContext())
        //    {
        //        sureNo = (from c in _context.Users select c).Where(t => t.Status.CompareTo(t.Status) == 3).Count();
        //        return sureNo;
        //    }
        //}
    }
}