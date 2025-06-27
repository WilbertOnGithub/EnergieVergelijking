using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Arentheym.EnergieVergelijker.Application;

[Flags]
[SuppressMessage("Usage", "CA1008:Enums should have zero value", Justification = "Translated to Dutch.")]
public enum IsolatieMaatregelenDto
{
    [Description("Geen")]
    Geen = 0, // Geen isolatie maatregelen
    [Description("HR++ glas (of beter)")]
    Glas = 1, // Ramen vervangen door HR++ glas
    [Description("Gevel isolatie")]
    Gevel = 2, // Kozijnen / deur vervangen
    [Description("Spouwmaar isolatie")]
    Spouwmuur = 4, // Spouwmuur geïsoleerd
    [Description("Kruipruimte isolatie")]
    Kruipruimte = 8, // Kruipruimte geïsoleerd
    [Description("Dak extra isolatie")]
    Dak = 16, // Extra isolatie op dak
}
