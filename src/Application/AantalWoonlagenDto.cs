using System.ComponentModel;

namespace Arentheym.EnergieVergelijker.Application;

/// <summary>
/// Aantal woonlagen van de woning
/// </summary>
public enum AantalWoonlagenDto
{
    [Description("Twee woonlagen")]
    Twee,
    [Description("Drie woonlagen")]
    Drie,
}
