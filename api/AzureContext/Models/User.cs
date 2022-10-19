using System;
using System.Collections.Generic;

#nullable disable

namespace AzureContext
{
        public partial class User
        {
            public User()
            {
                Comments = new HashSet<Comment>();
            }

            public long Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public bool IsAdmin { get; set; }

            public virtual Cart Cart { get; set; }
            public virtual Location Location { get; set; }
            public virtual ICollection<Comment> Comments { get; set; }
        }
}
