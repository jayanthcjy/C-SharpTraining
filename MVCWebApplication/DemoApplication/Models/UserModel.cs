﻿using System.ComponentModel.DataAnnotations;
namespace DemoApplication.Models

{
    
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? ConformPassword { get; set; }

    }
   
}
