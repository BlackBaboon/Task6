﻿namespace BackendApi.Contracts.User
{
    public class CreateUserRequest
    {
        public string Fio { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Adres { get; set; } = null!;
    }
}
