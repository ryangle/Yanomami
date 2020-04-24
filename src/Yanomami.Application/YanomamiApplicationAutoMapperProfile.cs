using AutoMapper;

namespace Yanomami
{
    public class YanomamiApplicationAutoMapperProfile : Profile
    {
        public YanomamiApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }
    }
}
