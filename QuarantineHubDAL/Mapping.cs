using AutoMapper;
using Quarantine.Entities;
using MVC.ViewModels;

namespace MVC.Database
{
    public static class Mapping
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>();
                cfg.CreateMap<PortfolioViewModel, User>();
                cfg.CreateMap<User, Subscriber>();
                cfg.CreateMap<UserViewModel, User>();
                cfg.CreateMap<UserViewModel, PortfolioViewModel>();
                cfg.CreateMap<UserViewModel, Subscriber>();
                cfg.CreateMap<UserViewModel, Like>();
                cfg.CreateMap<PostViewModel, Post>();
                cfg.CreateMap<Post, PostViewModel>();

            }).CreateMapper();
        }
    }
}
