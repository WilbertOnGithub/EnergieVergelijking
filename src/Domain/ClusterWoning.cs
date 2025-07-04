namespace Arentheym.EnergieVergelijker.Domain;

public class ClusterWoning(string code, int kiloWattUur, int kubiekeMeterGas)
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
    public IsolatieMaatregelen IsolatieMaatregelen { get; set; }

    /// <summary>
    /// Gezinssituatie van de bewoners
    /// </summary>
    public Gezinssituatie Gezinssituatie { get; set; }

    /// <summary>
    /// Gebruikt een open haard
    /// </summary>
    public GebruikOpenHaard GebruikOpenHaard { get; set; }

    /// <summary>
    /// Het type woning
    /// </summary>
    public WoningType WoningType { get; set; }

    /// <summary>
    /// Aantal woonlagen
    /// </summary>
    public AantalWoonlagen AantalWoonlagen { get; set; }

    /// <summary>
    /// Eventueel extra commentaar
    /// </summary>
    public string Commentaar { get; set; } = String.Empty;
}
