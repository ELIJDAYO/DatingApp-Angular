using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
// no need ? symbol in var?
        public string UserName {get; set;}
    }
}