﻿namespace Lab03JWTAPI.Domain
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public string Role {  get; set; }
    }
}
