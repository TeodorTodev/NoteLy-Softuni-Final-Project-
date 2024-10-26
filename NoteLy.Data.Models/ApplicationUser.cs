using Microsoft.AspNetCore.Identity;
using Notely.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteLy.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
        }

        //public ICollection<PlayList> PlayLists { get; set; } = new HashSet<PlayList>();
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
