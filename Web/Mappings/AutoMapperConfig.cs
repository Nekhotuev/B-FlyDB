using AutoMapper;

namespace Web.Mappings
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMap>();
                x.AddProfile<ViewModelToDomainMap>();
            });
        }
    }
}