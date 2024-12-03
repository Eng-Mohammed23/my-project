using AutoMapper;

namespace Hospital.Wep.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<PatientEntry, PatientEntryFormViewModel>();
        }
    }
}
