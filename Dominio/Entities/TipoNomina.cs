namespace Dominio.Entities;

public class TipoNomina : BaseEntity
{
    public string Nombre { get; set; }
    public ICollection<Persona> Personas { get; set; }

}
