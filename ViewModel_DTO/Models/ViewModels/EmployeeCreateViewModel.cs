﻿using System.ComponentModel.DataAnnotations;

namespace ViewModel_DTO.Models.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
      
    }
}
