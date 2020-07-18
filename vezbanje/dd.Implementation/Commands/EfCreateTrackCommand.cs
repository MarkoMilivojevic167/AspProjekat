using dd.Application.Commands;
using dd.Application.DataTransfer;
using dd.Implementation.Validators;
using EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Implementation.Commands
{
    public class EfCreateTrackCommand : ICreateTrackCommand
    {

        private readonly ChinookContext _context;
        private readonly CreateTrackValidator _validator;

        public EfCreateTrackCommand(ChinookContext context, CreateTrackValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 3;

        public string Name => "Create New Track using EF";

        public void Execute(TrackDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException

            var track = new Track
            {
                Name = request.Naziv,
                AlbumId = request.AlbumId,
                MediaTypeId = request.MediaTypeId,
                GenreId = request.GenreId,
                Composer = request.Composer,
                Milliseconds = (int)request.Sekunde * 1000,
                Bytes = (int)request.Megabajti * 1024 * 1024,
                UnitPrice = request.Cena
            };

            _context.Track.Add(track);

            _context.SaveChanges();
        }
    }
}
