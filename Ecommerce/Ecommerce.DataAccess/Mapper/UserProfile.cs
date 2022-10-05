using AutoMapper;
using Ecommerce.Models.DTOS.ProductCategory;
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
        }
    }
}
