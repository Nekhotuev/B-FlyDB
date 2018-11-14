using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace Web.Mappings
{
    public class ViewModelToDomainMap : Profile
    {
        public ViewModelToDomainMap()
        {
            //CreateMap<User, UserViewModel>();
            //and so on
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainmap"; }
        }
    }
}