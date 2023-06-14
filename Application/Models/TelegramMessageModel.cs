﻿using System.ComponentModel.DataAnnotations;

namespace Application.Models;

public class TelegramMessageModel
{
    [MaxLength(5, ErrorMessage = "Uzuuuun bo`ldi")]
    [Required(ErrorMessage = "Buni kiritish shart")]
    public string Name { get; set; }

    [EmailAddress]
    [Required]
    
    public string Email { get; set; }

    [MaxLength(150)]
    [Required]
    public string Subject { get; set; }

    [Required]
    [MaxLength(10)]
    public string Message { get; set; }

    public override string ToString()
    {
        return $"Name:{Name}\nEmail:{Email}\nSubject:{Subject}\nMessage:{Message}";
    }
}
