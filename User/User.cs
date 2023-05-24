using System;


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
