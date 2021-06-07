using System;
using System.Data.Entity;

namespace Stylist_Website_V5.Models
{
    public class CallBackDbInitializer : DropCreateDatabaseIfModelChanges<CallBackContext>
    {
        protected override void Seed(CallBackContext db)
        {
            db.CallBacks.Add(new CallBack { Id = Guid.NewGuid(), Name = "Test", Email = "test@mail.ru", Message = "123" });

            base.Seed(db);
        }
    }
}