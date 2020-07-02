using AspProjekat.Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspProjekat.Application.Searches
{
    public class UseCaseSearch : PageSearch
    {
        public string Email { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Name { get; set; }
        public bool NotAutorizedActor { get; set; }
    }
}

