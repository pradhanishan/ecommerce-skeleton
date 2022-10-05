using AutoMapper;
using Ecommerce.Models.DTOS.ProductCategory;
using Ecommerce.Models.DTOS.User;
using Ecommerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccess.Mapper
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ProductCategory, GetProductCategoryDTO>().ReverseMap();
            CreateMap<GetRegisterUserDTO, User>().ReverseMap();
            CreateMap<PostRegisterUserDTO, User>().ReverseMap();
            CreateMap<GetRegisterUserDTO, PostRegisterUserDTO>().ReverseMap();
        }
    }
}
