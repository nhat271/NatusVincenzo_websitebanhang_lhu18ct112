﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NatusVinceno_websitebanhang_lhu18ct112.Areas.Models
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}