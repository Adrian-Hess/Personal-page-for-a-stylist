using System.Data.Entity;

namespace Stylist_Website_V5.Models
{
    public class CallBackContext:DbContext
    {
        public DbSet<CallBack> CallBacks { get; set; }
        public DbSet<Request> Requests { get; set; }
    }
}