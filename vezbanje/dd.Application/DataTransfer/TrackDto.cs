using System;
using System.Collections.Generic;
using System.Text;

namespace dd.Application.DataTransfer
{
    public class TrackDto
    {
        public string Naziv { get; set; }

        public int AlbumId { get; set; }
        public int MediaTypeId { get; set; }

        public int GenreId { get; set; }
        public string Composer { get; set; }
        public double Sekunde { get; set; }
        public decimal Megabajti { get; set; }
        public decimal Cena { get; set; }
    }
}
