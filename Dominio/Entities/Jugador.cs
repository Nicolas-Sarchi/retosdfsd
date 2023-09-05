namespace Dominio.Entities;

public class Jugador : BaseEntity
{
    public int Dorsal { get; set; }
    public int IdPersonaFk { get; set; }
    public Persona Persona{ get; set; }
    public int IdPosicionFk { get; set; }
    public Posicion Posicion{ get; set; }
}
