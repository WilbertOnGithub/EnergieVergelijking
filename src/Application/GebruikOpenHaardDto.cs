using System.ComponentModel;

namespace Arentheym.EnergieVergelijker.Application;

/// <summary>
/// Maakt gebruik van een open haard
/// </summary>
public enum GebruikOpenHaardDto
{
    [Description("Gebruikt open haard")]
    Ja,
    [Description("Gebruikt geen open haard")]
    Nee, // Of geen open haard
}
