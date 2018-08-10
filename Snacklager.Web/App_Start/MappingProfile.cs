using AutoMapper;
using Snacklager.Data;
using Snacklager.Logic.Enums;
using Snacklager.Web.Models;
using System;

namespace Snacklager.Web.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Snack Display
            CreateMap<Snack, SnackDisplayVm>()
                .ForMember(dest => dest.SnackArt, src => src.MapFrom(opt => opt.SnackArtId));

            // Snack Create
            CreateMap<SnackCreateVm, Snack>()
                .ForMember(dest => dest.SnackArt, src => src.Ignore())
                .ForMember(dest => dest.Id, src => src.ResolveUsing(opt => 0));
        }
    }
}