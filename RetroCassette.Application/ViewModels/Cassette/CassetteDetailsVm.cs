using AutoMapper;
using RetoroCassette.Application.Mapping;
using RetroCassette.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroCassette.Application.ViewModels.Cassette
{
    public class CassetteDetailsVm : IMapFrom<RetroCassette.Domain.Model.Cassette>
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int MovieLength { get; set; }
        public virtual RetroCassette.Domain.Model.Director DirectorOfMovie { get; set; }
        public bool Availability { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string CassettePhoto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<RetroCassette.Domain.Model.Cassette, CassetteDetailsVm>();
        }
    }
}
