﻿using System;
using System.Collections.Generic;

namespace EShopperAPI.Models
{
    public partial class UserRequest
    {
        public UserRequest()
        {
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
