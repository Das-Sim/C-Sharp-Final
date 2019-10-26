using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //for primary key
using System.Linq;
using System.Threading.Tasks;

namespace EntityFirst1.Models
{
    public class UserInfoModel
    {
        //code first SPA

        [Key] //data annotation represents: primary key. requires using ^
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
