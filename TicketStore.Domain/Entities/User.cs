﻿using System;

namespace TicketStore.Domain.Entities
{
    public class User
    {
        public int? UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Login { get; set; }
    }
}