using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Models
{
    public class Client
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FullName { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.DateTime)]
        public string BirthDate { get; set; }

        public int IdDeviceNotification { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string FacebookId { get; set; }
    }
}
