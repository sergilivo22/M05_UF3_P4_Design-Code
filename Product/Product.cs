using System;
using System.Collections.Generic;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
    public List<string> Images { get; set; }
    public int CategoryId { get; set; }

    public Category Category { get; set; }
    public List<Wishlist> Wishlists { get; set; }
    public List<Review> Reviews { get; set; }