﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MaxLength(60, ErrorMessage = "Este Campo deve conter entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este Campo deve conter entre 3 a 60 caracteres")]
        public string Title { get; set; }

    }
}
