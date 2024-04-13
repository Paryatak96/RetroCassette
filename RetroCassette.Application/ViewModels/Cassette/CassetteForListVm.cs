using RetoroCassette.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroCassette.Application.ViewModels.Cassette
{
    public class CassetteForListVm : IMapFrom<RetroCassette.Domain.Model.Cassette>
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Language { get; set; }
        public string CassettePhoto { get; set; }
    }
}
