using System;
using System.Collections.Generic;

namespace WebAppiRest.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Username { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
