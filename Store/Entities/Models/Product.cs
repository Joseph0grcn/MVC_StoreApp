using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    // Bu tarz veritabanı kullanırken Id belirtilmesi zorunludur 

    public int Id { get; set; }
    public String? ProductName { get; set; } = String.Empty;
    public decimal Price { get; set; }
    public String? Summary { get; set; } = String.Empty;
    public String? ImageUrl{ get; set; } 
    public int? CategoryId { get; set; } //Foreign key
    public Category? category{ get; set; }  //navigation property
}
