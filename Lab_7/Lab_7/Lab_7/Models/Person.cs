using System;
using System.ComponentModel.DataAnnotations;

namespace Lab_7.Models
{
    public class Person
    {
        [Display(Name = "Фамилия")]
        [StringLength(30, ErrorMessage = "Длина строки от 2 до 30 символов", MinimumLength = 2)]
        public string Surname { get; set; }

        [Display(Name = "Имя")]
        [StringLength(30, ErrorMessage = "Длина строки от 2 до 30 символов", MinimumLength = 2)]
        public string Firstname { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(30, ErrorMessage = "Длина строки от 2 до 30 символов", MinimumLength = 2)]
        public string Middlename { get; set; }

        [Display(Name = "Дата рождения")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BDay { get; set; }

        [Key]
        [Display(Name = "Телефон")]
        [StringLength(10, ErrorMessage = "Длина строки от 9 до 10 символов", MinimumLength = 9)]
        public string Phone { get; set; }    
    }
}