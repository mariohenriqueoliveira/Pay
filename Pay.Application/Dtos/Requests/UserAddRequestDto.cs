﻿using System.ComponentModel.DataAnnotations;

namespace Pay.Application.Dtos.Requests
{
    public class UserAddRequestDto
    {
        [Required(ErrorMessage = "Informe o seu nome completo.")]
        [MinLength(8, ErrorMessage = "Informe o nome com pelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe o nome com no máximo {1} caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Informe o email de acesso.")]
        [EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a senha de acesso.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=])(?!.*\s).{8,}$",
        ErrorMessage = "Informe uma senha forte com pelo menos 8 caracteres, Exemplo: @Admin1234")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirme a senha de acesso.")]
        [Compare("Password", ErrorMessage = "Senhas não conferem.")]
        public string? PasswordConfirm { get; set; }
    }
}
