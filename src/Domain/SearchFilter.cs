namespace Arentheym.EnergieVergelijker.Domain;

public class SearchFilter
{
    public WoningType? WoningType { get; set; }
    public AantalWoonlagen? AantalWoonlagen { get; set; }
    public GebruikOpenHaard? GebruikOpenHaard { get; set; }
    public IsolatieMaatregelen? IsolatieMaatregelen { get; set; }
    public Gezinssituatie? Gezinssituatie { get; set; }

    public Range<int>? KiloWattUur { get; set; }

    public Range<int>? KubiekeMeterGas { get; set; }
}
