namespace Dominio.Entities;

public class Persona : BaseEntity
{
    public string NombrePersona { get; set; }
    public string ApellidoPersona { get; set;}
    public int EdadPersona { get; set; }
    public int IdTipoNomFk { get; set; }
    public TipoNomina TipoNomina{ get; set; }
    public int IdEquipoFk { get; set; }
    public Equipo Equipo{ get; set; }
    public Jugador Jugador{ get; set; }
}
