using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string BirthDate { get; set; }
        public int IdDeviceNotification { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string FacebookId { get; set; }
    }
}
