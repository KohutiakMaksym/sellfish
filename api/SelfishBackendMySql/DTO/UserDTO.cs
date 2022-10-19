using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfishBackendMySql.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdmin { get; set; }

    }
}
