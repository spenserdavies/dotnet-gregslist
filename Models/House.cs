using System.ComponentModel.DataAnnotations;

namespace fullstack_gregslist.Models
{
    public class House
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public int Beds { get; set; }
        [Required]
        public int Baths { get; set; }
        [Required]
        public int Floors { get; set; }
        [Required]
        public string City { get; set; }
        
        public string State { get; set; }
        [Required]
        public int Price { get; set; }
    }

    public class ViewModelHouseFavorite : House
    {
        public int FavoriteId { get; set; }
    }
}