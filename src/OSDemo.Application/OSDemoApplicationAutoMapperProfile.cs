using AutoMapper;
using OSDemo.Books;

namespace OSDemo;

public class OSDemoApplicationAutoMapperProfile : Profile
{
    public OSDemoApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
