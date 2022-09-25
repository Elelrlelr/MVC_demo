


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book
{
    public int Id { get; set; }


    [StringLength(60, MinimumLength = 3), Required]
    public string Title { get; set; } = null!;
    

    [StringLength(60, MinimumLength = 3), Required]
    public string Author { get; set; } = null!;


    [Range(1, 100), DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; } = default;


    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
    public string Genre { get; set; } = null!;


    [Display(Name = "Release Date")]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
    // [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }


    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(5)]
    public string? Rating { get; set; }

}
