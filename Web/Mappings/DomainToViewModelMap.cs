using AutoMapper;
using Core.Model;

namespace Web.Mappings
{
    public class DomainToViewModelMap : Profile
    {
        public DomainToViewModelMap()
        {
            CreateMap<AirportScheme, AirportSchemeViewModel>();
            CreateMap<Airport, AirportViewModel>();
            CreateMap<City, CityViewModel>();
            CreateMap<Country, CountryViewModel>();
            CreateMap<Flight, FlightViewModel>();
            CreateMap<Gate, GateViewModel>();
            CreateMap<Plane, PlaneViewModel>();
            CreateMap<Reservation, ReservationViewModel>();
            CreateMap<ServiceClass, ServiceClassViewModel>();
            CreateMap<Terminal, TerminalViewModel>();
            CreateMap<TimeTable, TimeTableViewModel>();
            CreateMap<User, UserViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMap"; }
        }
    }
}