namespace Arentheym.EnergieVergelijker.Application;

public class ClusterWoningDto(string code, int kiloWattUur, int kubiekeMeterGas)
{
    /// <summary>
    /// Unieke deelnemers code
    /// </summary>
    public string Code { get; } = code;

    /// <summary>
    /// Verbruik aantal KWh per jaar
    /// </summary>
    public int KiloWattUur { get; } = kiloWattUur;

    /// <summary>
    /// Verbruik aantal kubieke meter gas per jaar
    /// </summary>
    public int KubiekeMeterGas { get; } = kubiekeMeterGas;

    /// <summary>
    /// Uitgevoerde isolatie maatregelen
    /// </summary>
    public IsolatieMaatregelenDto IsolatieMaatregelen { get; set; }

    /// <summary>
    /// Gezinssituatie van de bewoners
    /// </summary>
    public GezinssituatieDto Gezinssituatie { get; set; }

    /// <summary>
    /// Gebruikt een open haard
    /// </summary>
    public GebruikOpenHaardDto GebruikOpenHaard { get; set; }

    /// <summary>
    /// Het type woning
    /// </summary>
    public WoningTypeDto WoningType { get; set; }

    /// <summary>
    /// Aantal woonlagen
    /// </summary>
    public AantalWoonlagenDto AantalWoonlagen { get; set; }

    /// <summary>
    /// Eventueel extra commentaar
    /// </summary>
    public string Commentaar { get; set; } = String.Empty;

    public IReadOnlyList<string> ToolTipLines()
    {
        var lines = new List<string>();
        lines.Add($"{Gezinssituatie.GetDescription()}");
        lines.Add($"{WoningType.GetDescription()}");
        lines.Add($"{AantalWoonlagen.GetDescription()}");
        lines.Add($"{GebruikOpenHaard.GetDescription()}");

        var isolatieMaatregelen = new List<string>();
        foreach (IsolatieMaatregelenDto measure in Enum.GetValues<IsolatieMaatregelenDto>())
        {
            if (measure == IsolatieMaatregelenDto.Geen)
            {
                continue;
            }

            if (IsolatieMaatregelen.HasFlag(measure))
            {
                isolatieMaatregelen.Add($"- {measure.GetDescription()}");
            }
        }

        if (isolatieMaatregelen.Count > 0)
        {
            lines.AddRange(isolatieMaatregelen);
        }
        if (!string.IsNullOrEmpty(Commentaar))
        {
            lines.Add("Commentaar");
            lines.Add($"{Commentaar}");
        }

        return lines;
    }
}
