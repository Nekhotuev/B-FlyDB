using AutoMapper;
using Core.Model;

namespace Web.Mappings
{
    public class DomainToViewModelMap : Profile
    {
        public DomainToViewModelMap()
        {
            //CreateMap<User, UserViewModel>();
            //and so on
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMap"; }
        }
    }
}