
using System.ComponentModel.DataAnnotations;

namespace WebCake1.Models
{
    public  class Cake
    {

        public Cake() { }

        public Cake(int id, string title, string description, decimal price, string imageFileName)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            ImageFileName = imageFileName;
        }

        public int Id { get; set; } = -1;

        [Required]
        public string Title { get; set; } = string.Empty; 

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; } = 0.0M;

        [Required]
        public int Quantity { get; set; } = 1;

        [Required]
        public CakeSize Size { get; set; } = CakeSize.Medium;

        public string ImageFileName { get; set; } = string.Empty;

        public virtual string GetCakeType()
        {
            return this.GetType().Name;
        }
    }


    public class CupCake:Cake
    {
        public CupCake() : base()
        {}
        public CupCake(int id, string title, string description, decimal price, string imageFileName) : base(id,title, description, price, imageFileName)
        {
        }

        public new string GetCakeType()
        {
            return this.GetType().Name;
        }
    }

    public class WeddingCake : Cake
    {

        public WeddingCake() : base()
        { }

        public WeddingCake(int id, string title, string description, decimal price, string imageFileName) : base(id,title, description, price, imageFileName)
        {
        }
        public new string GetCakeType()
        {
            return this.GetType().Name;
        }
    }


    public enum CakeSize : uint  //32 are the maximum
    {
        Large = 0,
        Medium = 2,
        Small = 4

    }// enum CakeSize
}//namespace


