using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Teste_Hexagon.Model;

public class Pessoa
{
    public int Id { get; set; }
    
    [Required]
    public string? Nome { get; set; }
    
    [Required]
    public int Idade { get; set; }

    [Required]
    public string? EstadoCivil { get; set; }

    [Required]
    public string? CPF { get; set; }

    [Required]
    public string? Cidade { get; set; }

    [Required]
    public string? Estado { get; set; }
}
