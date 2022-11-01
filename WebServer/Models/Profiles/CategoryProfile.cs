using AutoMapper;
using DataLayer;
using DataLayer.Model;
namespace WebServer.Models.Profiles
    
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryModel>();
            CreateMap<CategoryModel, Category>();


        }
    }
}
