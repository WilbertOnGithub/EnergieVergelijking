namespace Arentheym.EnergieVergelijker.Domain;

[Flags]
public enum IsolatieMaatregelen
{
    Glas = 1, // Ramen vervangen door HR++ glas
    Gevel = 2, // Kozijnen / deur vervangen
    Spouwmuur = 4, // Spouwmuur geïsoleerd
    Kruipruimte = 8, // Kruipruimte geïsoleerd
    Dak = 16, // Extra isolatie op dak
}
