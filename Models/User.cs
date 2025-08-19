using Microsoft.AspNetCore.Components;

namespace BlazorWebAppMovies.Models;

public class User
{
    public int? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? CardType{ get; set; }
    public string? Agency { get; set; }
    
    
 
}