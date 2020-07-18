using dd.Application.DataTransfer;
using EfDataAccess;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Implementation.Validators
{
    public class CreateTrackValidator : AbstractValidator<TrackDto>
    {
        public CreateTrackValidator(ChinookContext context)
        {
            RuleFor(x => x.Naziv).NotEmpty().WithMessage("Naziv is required");
            RuleFor(x => x.AlbumId).NotEmpty().WithMessage("AlbumId is required");
            RuleFor(x => x.GenreId).NotEmpty().WithMessage("GenreId is required");
            RuleFor(x => x.Sekunde)
                .NotEmpty()
                .GreaterThan(90)
                .WithMessage("Pesma mora imati vise od 90 sekindi"); 


            RuleFor(x => x.Cena)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Cena mora biti jedan ili veca");

            RuleFor(x => x.Megabajti)
                .NotEmpty()
                .GreaterThan(1000).WithMessage("Mora imati vise od 1 mb");

            RuleFor(x => x.MediaTypeId)
                .NotEmpty()
                .WithMessage("MediaTypeId is required");


        }
    }
}
