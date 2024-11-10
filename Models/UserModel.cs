﻿namespace api.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty.ToString();
        public string EmailConfirmed { get; set; } = string.Empty;
    }
}