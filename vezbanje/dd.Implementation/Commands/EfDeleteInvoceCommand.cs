using dd.Application.Commands;
using dd.Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dd.Implementation.Commands
{
    public class EfDeleteInvoceCommand : IDeleteInvoceCommand
    {
        private readonly ChinookContext _context;

        public EfDeleteInvoceCommand(ChinookContext context)
        {
            this._context = context;
        }

        public int Id => 2;

        public string Name => "Deleting playlist";

        public void Execute(int request)
        {
            var sadrzaj = _context.PlaylistTrack.Count(x=>x.PlaylistId==request);

            if (sadrzaj == 0)
            {
                var plejlista = _context.Playlist.Find(request);

                _context.Playlist.Remove(plejlista);
                _context.SaveChanges();
            }
            else
            {
                throw new EntityNotFoundException(request, typeof(Playlist));
            }

            

            _context.SaveChanges();
        }
    }
}
