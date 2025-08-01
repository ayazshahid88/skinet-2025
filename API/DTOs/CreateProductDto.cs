using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;

namespace API.DTOs;

public class CreateProductDto
{
    [System.ComponentModel.DataAnnotations.Required]
    public string Name { get; set; } = string.Empty;
 
     [System.ComponentModel.DataAnnotations.Required]
    public string Description { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
    public decimal Price { get; set; }

    [System.ComponentModel.DataAnnotations.Required]
    public string PictureUrl { get; set; } = string.Empty;

    [System.ComponentModel.DataAnnotations.Required]
    public string Type { get; set; } = string.Empty;

    [System.ComponentModel.DataAnnotations.Required]
    public string Brand { get; set; } = string.Empty;

    [Range(1, int.MaxValue, ErrorMessage = "Quantity in stock must be at least 1.")] 
    public int QuantityInStock { get; set; }

}
