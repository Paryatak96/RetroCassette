using AutoMapper;
using FluentValidation;
using RetoroCassette.Application.Mapping;
using RetroCassette.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroCassette.Application.ViewModels.Cassette
{
    public class NewCassetteVm : IMapFrom<RetroCassette.Domain.Model.Cassette>
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int MovieLength { get; set; }
        public virtual Director DirectorOfMovie { get; set; }
        public bool Availability { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string CassettePhoto { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCassetteVm, RetroCassette.Domain.Model.Cassette>().ReverseMap();
        }
    }

    public class NewCassetteValidation : AbstractValidator<NewCassetteVm>
    {
        public NewCassetteValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.MovieTitle).MaximumLength(100);
        }
    }
}
