using System.ComponentModel;

namespace Arentheym.EnergieVergelijker.Application;

/// <summary>
/// Gezinssituatie
/// </summary>
public enum GezinssituatieDto
{
    [Description("Alleenstaand")]
    Alleenstaand,
    [Description("Twee personen")]
    TweePersonen,
    [Description("Gezin")]
    Gezin, // Gezin met meer dan 2 personen
}
