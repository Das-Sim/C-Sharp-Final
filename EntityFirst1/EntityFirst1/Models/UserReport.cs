using Microsoft.EntityFrameworkCore; //for inheritance ":"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFirst1.Models
{
    public class UserReport : DbContext //Database Context. using entity framework for inheritance. for dynamic content.
    {
        public UserReport(DbContextOptions<UserReport> options) : base(options) //extended with base options
        {

        }

        public DbSet<UserInfoModel> UserTable { get; set; } //define type of data set "Userinfomodel"

    }
}
