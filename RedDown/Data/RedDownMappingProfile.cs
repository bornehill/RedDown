using AutoMapper;
using RedDown.Data.Entities;
using RedDown.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.Data
{
    public class RedDownMappingProfile : Profile
    {
        public RedDownMappingProfile() {
            CreateMap<RegistryDown, RegistryDownViewModel>()
                .ForMember(o => o.DownId, ex => ex.MapFrom(o => o.Id))
                .ForMember(o => o.BirthPlace,
                 ex => ex.MapFrom(o => (States)o.BirthPlace))
                .ForMember(o => o.ResidencePlace,
                 ex => ex.MapFrom(o => (States)o.ResidencePlace))
                .ForMember(o => o.MainCarer,
                 ex => ex.MapFrom(o => (MainCarer)o.MainCarer))
                .ForMember(o => o.DiagnosticTime,
                 ex => ex.MapFrom(o => (Diagnostic)o.DiagnosticTime))
                .ForMember(o => o.MedicalCare,
                 ex => ex.MapFrom(o => (MedicalAtention)o.MedicalCare))
                 .ReverseMap();

            CreateMap<Parent, ParentViewModel>()
                .ForMember(o => o.ParentId, ex => ex.MapFrom(o => o.Id))
                .ForMember(o => o.Pupilage,
                 ex => ex.MapFrom(o => (Pupilage)o.Pupilage))
                .ReverseMap();

            CreateMap<Questions, QuestionsViewModel>()
                .ForMember(o => o.QId, ex => ex.MapFrom(o => o.Id))
                .ForMember(o => o.InterTemprana,
                 ex => ex.MapFrom(o => (ActivityTherapy)o.InterTemprana))
                .ForMember(o => o.TerapiaLeng,
                 ex => ex.MapFrom(o => (ActivityTherapy)o.TerapiaLeng))
                .ForMember(o => o.TerapiaFam,
                 ex => ex.MapFrom(o => (ActivityTherapy)o.TerapiaFam))
                .ForMember(o => o.TerapiaAprenz,
                 ex => ex.MapFrom(o => (ActivityTherapy)o.TerapiaAprenz))
                .ForMember(o => o.ActActual,
                 ex => ex.MapFrom(o => (ActivitySchool)o.ActActual))
                .ReverseMap();
        }
    }
}
