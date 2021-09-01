
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class TvShow
    {

        public int Id { get; set; }
        public string Isim = "Dizi İzleme Linki";
        public string Link = "Imdb Linki";
        [Required]
        [StringLength(60,MinimumLength =3)]
        [Display(Name ="Başlık")]
        public string Title { get; set; }
        [Required]
        [Display(Name ="Tür")]
        public Genre Genre { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:0.0#}")]
        [Display(Name ="Reyting")]
        public decimal Rating { get; set; }
        [Required]
        [DataType(DataType.Url)]
        [Display(Name ="Imdb Link")]
        public string ImdbUrl { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name ="Resim")]
        public string ImageUrl { get; set; }
        [Required]
        [DataType(DataType.Url)]
        [Display(Name ="Diziyi İzle")]
        public string WatchMovieUrl { get; set; }




    }
}
