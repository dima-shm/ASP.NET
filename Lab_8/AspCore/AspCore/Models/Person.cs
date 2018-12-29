using AspCore.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [Required]
        [RegularExpression(@"^[а-яА-Я.]{2,30}$", ErrorMessage = "Только русские буквы")]
        public string Firstname { set; get; }

        [Required]
        [RegularExpression(@"^[а-яА-Я.]{2,30}$", ErrorMessage = "Только русские буквы")]
        public string Surname { set; get; }

        [DataType(DataType.Date, ErrorMessage = "Выберите дату")]
        [CustomValidator(120)]
        public DateTime BDay { set; get; }

        public string Gender { set; get; }

        public Person() { }
    }
}
