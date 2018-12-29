using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewVideo1.Models
{
    public class VideoModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Display(Name = "Файл")]
        public string Path { get; private set; }

        [Display(Name = "Название")]
        public string Title { get; private set; }

        public VideoModel()
        {
            Title = "";
            Path = "";
        }

        public VideoModel(string path, string name)
        {
            Title = name;
            Path = path;
        }
    }
}