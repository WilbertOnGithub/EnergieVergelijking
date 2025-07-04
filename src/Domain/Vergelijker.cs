namespace Arentheym.EnergieVergelijker.Domain;

public class Vergelijker
{
    private readonly List<ClusterWoning> _clusterWoningen = [];
    private string _code = string.Empty;

    public Vergelijker()
    {
        Seed();
    }

    public bool CodeExists(string code)
    {
        _code = code;
        return _clusterWoningen.FirstOrDefault(x => x.Code.Equals(code, StringComparison.OrdinalIgnoreCase)) != null;
    }

    public IReadOnlyList<ClusterWoning> Search([NotNull] SearchFilter filter, string optionalCode = "")
    {
        var query = _clusterWoningen.AsQueryable();

        if (filter.AantalWoonlagen.HasValue)
        {
            query = query.Where(x => x.AantalWoonlagen == filter.AantalWoonlagen.Value);
        }

        if (filter.GebruikOpenHaard.HasValue)
        {
            query = query.Where(x => x.GebruikOpenHaard == filter.GebruikOpenHaard.Value);
        }

        if (filter.Gezinssituatie.HasValue)
        {
            query = query.Where(x => x.Gezinssituatie == filter.Gezinssituatie.Value);
        }

        if (filter.WoningType.HasValue)
        {
            query = query.Where(x => x.WoningType == filter.WoningType.Value);
        }

        if (filter.IsolatieMaatregelen.HasValue)
        {
            // Return all ClusterWoningen where at least one of the selected measures is present
            query = query.Where(w => (w.IsolatieMaatregelen & filter.IsolatieMaatregelen) != 0);
        }

        if (filter.KiloWattUur != null)
        {
            query = query.Where(x => filter.KiloWattUur.Contains(x.KiloWattUur));
        }

        if (filter.KubiekeMeterGas != null)
        {
            query = query.Where(x => filter.KubiekeMeterGas.Contains(x.KubiekeMeterGas));
        }

        // Haal eigen woning uit zoekresultaat en plaats deze als eerste in de lijst
        var result = query.ToList();
        if (!string.IsNullOrEmpty(optionalCode))
        {
            var eigenWoning = _clusterWoningen.Single(x => x.Code == optionalCode);
            result.Remove(eigenWoning);
            result.Insert(0, eigenWoning);
        }

        return result.ToList().AsReadOnly();
    }

    private void Seed()
    {
        _clusterWoningen.Add(
            new ClusterWoningBuilder("dk72ln", 966, 1018)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Alleenstaand)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("5medg0", 3315, 1389)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("uln5sq", 1100, 850)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Spouwmuur | IsolatieMaatregelen.Dak
                )
                .WithCommentaar(
                    "Bovenstaande cijfers zijn geschat op basis van het verbruik in de eerste maanden van 2023."
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("7ze6tr", 3163, 612)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("Hybride warmtepomp aanwezig.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("zfs4m7", 1689, 248)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Alleenstaand)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Glas | IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Dak)
                .WithCommentaar("Triple glas (HR +++) in gevel.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("nafvbv", 1921, 1048)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Kruipruimte)
                .WithCommentaar("Gevelisolatie + installatie HR++ glas voor 50% uitgevoerd.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("wlv572", -227, 1300)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Ja)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Spouwmuur | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("16 zonnepanelen aanwezig. HR++ glas slechts deels.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("9d4wsi", 4000, 2000)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("mh0ivx", 3400, 1350)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Alleenstaand)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Spouwmuur
                )
                .WithCommentaar("Hele dag schaduw door hoge bomen rondom.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("nxbvbv", 2700, 850)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Spouwmuur)
                .WithCommentaar("Verwarming op 15 - 17 graden overdag. 18 graden in de avond.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("64euzb", 3458, 122)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Ja)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Kruipruimte | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("Clusterkieren luchtdicht gemaakt. Klepraampjes deels geïsoleerd.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("mbfivx", 3609, 830)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("Vanaf 13 november 2023 warmtepomp (full electric) geïnstalleerd.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("kffb7w", -204, 583)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Spouwmuur | IsolatieMaatregelen.Kruipruimte
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("h9zewn", 2526, 1391)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("iegklw", 3276, 694)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("5fdg0x", 2600, 900)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Ja)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("8 zonnepanelen (300 Watt piek), 280 liter zonneboiler, triple glas (HR+++)")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("wyj572", 8000, 5600)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Ja)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("Electrische auto. Zwembad.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("2hzwor", 4292, 529)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar(
                    "22 zonnepanelen. Electrische auto. 1 warmtepomp + backup CV (voor warm water)."
                        + Environment.NewLine
                        + "10440 KWh verbruikt maar 6148 zelf opgewekt."
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("qaj9o3", -845, 1105)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Kruipruimte | IsolatieMaatregelen.Dak
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("s0ehem", 1600, 2000)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Alleenstaand)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Geen)
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("l4yayf", -583, 1300)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Kruipruimte)
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("jst3ug", 3508, 1123)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Spouwmuur | IsolatieMaatregelen.Kruipruimte | IsolatieMaatregelen.Dak
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("uwin5s", 3249, 1387)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Ja)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Spouwmuur | IsolatieMaatregelen.Kruipruimte
                )
                .WithCommentaar("Gevelisolatie alleen achter.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("8nyg0s", 2151, 764)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Spouwmuur
                )
                .WithCommentaar("Hybride plugin auto")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("ycnm5x", 1300, 1400)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                )
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("r0wpu6", 1669, 1030)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas | IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Kruipruimte
                )
                .WithCommentaar("Incidenteel gebruik van gashaard. Incidenteel gebruik van elektrische bijverwarming.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("w4i572", 631, 1368)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("Zonnepanelen. Electrische auto.")
                .Build()
        );

        // Eigen woning - Beethovenlaan 80
        _clusterWoningen.Add(
            new ClusterWoningBuilder("n5lvbv", 2625, 875)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(
                    IsolatieMaatregelen.Glas
                        | IsolatieMaatregelen.Gevel
                        | IsolatieMaatregelen.Spouwmuur
                        | IsolatieMaatregelen.Kruipruimte
                        | IsolatieMaatregelen.Dak
                )
                .WithCommentaar("Zonnepanelen. Electrische auto.")
                .Build()
        );
    }
}
