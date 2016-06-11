using AutoMapper;
using dotnetcore_MVC6_example.Models.CardViewModels;
using dotnetcore_MVC6_example.Models.CategoryViewModels;
using dotnetcore_MVC6_example.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_MVC6_example.Infrastructure.Mapping
{
    public class DomainToViewModelMappingProfile:Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Card, CardViewModel>()
               .ForMember(vm => vm.ImageUrl, map => map.MapFrom(p => "/images/" + p.ImageUrl));

            //Mapper.CreateMap<Category, CategoryViewModel>()
            //    .ForMember(vm => vm.TotalCard, map => map.MapFrom(a => a.Cards.Count))
            //    .ForMember(vm => vm.ImageUrl, map =>
            //        map.MapFrom(a => (a.ImageUrl != null) ?
            //        "/images/" + a.Photos.First().Uri :
            //        "/images/thumbnail-default.png"));
        }
    }
}
