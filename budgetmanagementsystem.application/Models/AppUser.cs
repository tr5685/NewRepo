﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanagementsystem.application.Models
{
    public class AppUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }= string.Empty;
        public string Email { get; set; }=string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool IsAccountActived { get; set; } = true;
        
    }
}
