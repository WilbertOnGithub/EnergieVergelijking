namespace Arentheym.EnergieVergelijker.Application;

public class SearchFilterDto
{
    public WoningTypeDto? WoningType { get; set; }
    public AantalWoonlagenDto? AantalWoonlagen { get; set; }
    public GebruikOpenHaardDto? GebruikOpenHaard { get; set; }
    public IsolatieMaatregelenDto? IsolatieMaatregelen { get; set; }
    public GezinssituatieDto? Gezinssituatie { get; set; }

    public (int min, int max)? KiloWattUur { get; set; }

    public (int min, int max)? KubiekeMeterGas { get; set; }
}
