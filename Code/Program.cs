using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Dni { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    public List<Wishlist> Wishlists { get; set; }
    public List<Review> Reviews { get; set; }
}

public class Wishlist
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ProductId { get; set; }

    public User User { get; set; }
    public Product Product { get; set; }
}

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
}

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ParentId { get; set; }
    public List<Category> Children { get; set; }
    public List<Product> Products { get; set; }
}

public class Review
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int UserId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }

    public Product Product { get; set; }
    public User User { get; set; }
}

