using System.Collections.Generic;
using System;
using System.Data.Entity;

namespace DAL
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<AdminInfo> adminInfos = new List<AdminInfo>();

            adminInfos.Add(new AdminInfo() { Email = "ravi@gmail.com", Password = "ravi123" });
            adminInfos.Add(new AdminInfo() { Email = "kishore@gmail.com", Password = "kishore123" });

            context.AdminInfos.AddRange(adminInfos);
            context.SaveChanges();

            List<EmpInfo> empInfos = new List<EmpInfo>();
            empInfos.Add(new EmpInfo() { Email = "ram@gmail.com", PassCode = 100, DateOfJoining = new DateTime(2020, 10, 05), Name = "ram" });
            empInfos.Add(new EmpInfo() { Email = "sam@gmail.com", PassCode = 100, DateOfJoining = new DateTime(2019, 10, 25), Name = "sam" });
            empInfos.Add(new EmpInfo() { Email = "bheem@gmail.com", PassCode = 100, DateOfJoining = new DateTime(2020, 11, 05), Name = "bheem" });
            context.EmpInfos.AddRange(empInfos);
            context.SaveChanges();

            List<BlogInfo> blogInfos = new List<BlogInfo>();
            blogInfos.Add(new BlogInfo() { Email = "ram@gmail.com", BlogUrl = "https://en.wikipedia.org/wiki/Oppenheimer_(film)", DateOfCreation = new DateTime(2020, 10, 10), Subject = "Photography", Title = "Intrsteller" });
            blogInfos.Add(new BlogInfo() { Email = "sam@gmail.com", BlogUrl = "https://en.wikipedia.org/wiki/Oppenheimer_(film)", DateOfCreation = new DateTime(2020, 10, 26), Subject = "Direction", Title = "Inception" });
            blogInfos.Add(new BlogInfo() { Email = "bheem@gmail.com", BlogUrl = "https://en.wikipedia.org/wiki/Oppenheimer_(film)", DateOfCreation = new DateTime(2020, 11, 06), Subject = "story", Title = "Openheimer" });
            context.BlogInfos.AddRange(blogInfos);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}