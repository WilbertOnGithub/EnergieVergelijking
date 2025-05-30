namespace Arentheym.EnergieVergelijker.Domain;

public class SearchFilter
{
    public WoningType? WoningType { get; set; }
    public AantalWoonlagen? AantalWoonlagen { get; set; }
    public GebruikOpenHaard? GebruikOpenHaard { get; set; }
    public IsolatieMaatregelen IsolatieMaatregelen { get; set; } = IsolatieMaatregelen.Geen;
    public Gezinssituatie? Gezinssituatie { get; set; }
}
