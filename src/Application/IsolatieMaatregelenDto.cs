using System.Diagnostics.CodeAnalysis;

namespace Arentheym.EnergieVergelijker.Domain;

[Flags]
[SuppressMessage("Usage", "CA1008:Enums should have zero value", Justification = "Translated to Dutch.")]
public enum IsolatieMaatregelenDto
{
    Geen = 0, // Geen isolatie maatregelen
    Glas = 1, // Ramen vervangen door HR++ glas
    Gevel = 2, // Kozijnen / deur vervangen
    Spouwmuur = 4, // Spouwmuur geïsoleerd
    Kruipruimte = 8, // Kruipruimte geïsoleerd
    Dak = 16, // Extra isolatie op dak
}
