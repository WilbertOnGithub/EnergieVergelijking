using System.ComponentModel;

namespace Arentheym.EnergieVergelijker.Application;

/// <summary>
/// Maakt gebruik van een open haard
/// </summary>
public enum GebruikOpenHaardDto
{
    [Description("Ja")]
    Ja,
    [Description("Nee")]
    Nee, // Of geen open haard
}
