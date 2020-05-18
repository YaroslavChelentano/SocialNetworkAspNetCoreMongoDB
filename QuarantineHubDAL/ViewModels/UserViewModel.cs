using CovidSharp;
using Quarantine.Entities;
using System.Collections.Generic;

namespace MVC.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Nickname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public List<Subscriber> Subscribers { get; set; }
        public string Image { get; set; }
    }
}
