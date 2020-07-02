using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.DataTransfer
{
    public class GetUserDto
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
    }
}
