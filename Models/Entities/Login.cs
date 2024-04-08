﻿using System.ComponentModel.DataAnnotations;

namespace HRMS.Models.Entities
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}