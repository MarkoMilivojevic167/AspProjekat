using dd.Application.DataTransfer;
using dd.Application.Queries;
using dd.Application.Searches;
using EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dd.Implementation.Queries
{
    public class EfGetInvoceQuery : IGetInvoceQuery
    {
        private readonly ChinookContext context;

        public EfGetInvoceQuery(ChinookContext context)
        {
            this.context = context;
        }

        public int Id => 1;

        public string Name => "Invoce search.";

        public PagedResponse<InvoceDto> Execute(InvoceSearch search)
        {
            var query = context.Invoice.Include(x=>x.InvoiceLine).ThenInclude(x=>x.Track).AsQueryable();

            if (!string.IsNullOrEmpty(search.Naziv) || !string.IsNullOrWhiteSpace(search.Naziv))
            {
                query = query.Where(x => x.InvoiceLine.Any(x=>x.Track.Name.ToLower().Contains(search.Naziv.ToLower())));
            }


            if (!string.IsNullOrEmpty(search.Kompanija) || !string.IsNullOrWhiteSpace(search.Kompanija))
            {
                query = query.Where(x => x.Customer.Company.ToLower().Contains(search.Kompanija.ToLower()));
            }

            if (search.min>0)
            {
                query = query.Where(x=>x.Total >= search.min);
            }

            if (search.max>0)
            {
                query = query.Where(x => x.Total <= search.max);
            }

            if (!string.IsNullOrEmpty(search.Drzava) || !string.IsNullOrWhiteSpace(search.Drzava))
            {
                query = query.Where(x => x.BillingCountry.ToLower().Contains(search.Drzava.ToLower()));
            }
            if (search.IdKorisnik > 0)
            {
                query = query.Where(x => x.CustomerId == search.IdKorisnik);
            }



            var skipCount = search.PerPage * (search.Page - 1);

            //Page == 1 
            var reponse = new PagedResponse<InvoceDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x => new InvoceDto
                {
                    Id = x.InvoiceId,
                    ImeKupca = x.Customer.FirstName,
                    PrezimeKupca=x.Customer.LastName,
                    EmailKupca=x.Customer.Email,
                    TelefonKupca=x.Customer.Phone,
                    BillingAdresa=x.BillingAddress,
                    BillingDrzava=x.BillingCountry,
                    BillingGrad=x.BillingCity,
                    BillingPostanskiBroj=x.BillingPostalCode,
                    BillingRegion=x.BillingState,
                    StavkeFakture=x.InvoiceLine.Where(y=>y.InvoiceId==x.InvoiceId).Select(f=>new stavkeFakture
                    {
                        Cena=f.UnitPrice,
                        Id=f.InvoiceLineId,
                        NazivPesme=f.Track.Name,
                        Kolicina=f.Quantity
                    }).ToList()

                })
            };

            return reponse;
        }
    }
}
