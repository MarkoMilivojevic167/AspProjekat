using dd.Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Application.Searches
{
    public class InvoceSearch : PagedSearch
    {
        public int IdKorisnik { get; set; }
        public string Naziv { get; set; }
        public string Kompanija { get; set; }
        public string Drzava { get; set; }
        public decimal min { get; set; }
        public decimal max { get; set; }
    }
}
