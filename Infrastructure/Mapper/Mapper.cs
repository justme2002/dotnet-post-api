using AutoMapper;
using Domain.DTO;
using Domain.Entities.Book;
using Domain.Entities.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookEntity, BookViewModel>();
            CreateMap<BookViewModel, BookEntity>();
            CreateMap<ReviewEntity, ReviewViewModel>();
            CreateMap<ReviewViewModel, ReviewEntity>();
            CreateMap<List<BookEntity>, List<BookViewModel>>().ForMember("Item", opt => opt.Ignore());
        }
    }
}
