using Microsoft.EntityFrameworkCore;

namespace ApiEstudiantesNet8.Models;

[PrimaryKey(nameof(id_estudiante))]
public class Estudiantes {
    
    public Int32? id_estudiante {get; set;}

    public string? carnet {get; set;}

    public string? nombres {get; set;}

    public string? apellidos {get; set;}

    public string? direccion {get; set;}

    public string? telefono {get; set;}

    public string? correo_electronico {get; set;}

    public Int32? id_tipo_sangre {get; set;}

    public DateTime? fecha_nacimiento {get; set;}

}