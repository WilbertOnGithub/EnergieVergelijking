namespace Arentheym.EnergieVergelijker.Domain;

public class Vergelijker
{
    private List<ClusterWoning> _clusterWoningen = new List<ClusterWoning>();

    public Vergelijker()
    {
        Seed();
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
            new ClusterWoningBuilder("5medg0", 1389, 3315)
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
            new ClusterWoningBuilder("uln5sq", 850, 1100)
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
            new ClusterWoningBuilder("7ze6tr", 612, 3163)
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
            new ClusterWoningBuilder("zfs4m7", 248, 1689)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Alleenstaand)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Glas | IsolatieMaatregelen.Gevel | IsolatieMaatregelen.Dak)
                .WithCommentaar("Triple glas (HR +++) in gevel.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("nafvbv", 1048, 1921)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.Gezin)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Kruipruimte)
                .WithCommentaar("Gevelisolatie + installatie HR++ glas voor 50% uitgevoerd.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("wlv572", 1300, -227)
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
            new ClusterWoningBuilder("9d4wsi", 2000, 4000)
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
            new ClusterWoningBuilder("mh0ivx", 1350, 3400)
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
            new ClusterWoningBuilder("nxbvbv", 850, 2700)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Spouwmuur)
                .WithCommentaar("Verwarming op 15 - 17 graden overdag. 18 graden in de avond.")
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("64euzb", 122, 3458)
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
            new ClusterWoningBuilder("mbfivx", 830, 3609)
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
            new ClusterWoningBuilder("kffb7w", 583, -204)
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
            new ClusterWoningBuilder("h9zewn", 1391, 2526)
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
            new ClusterWoningBuilder("iegklw", 694, 3276)
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
            new ClusterWoningBuilder("5fdg0x", 900, 2600)
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
            new ClusterWoningBuilder("wyj572", 5600, 8000)
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
            new ClusterWoningBuilder("2hzwor", 529, 4292)
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
            new ClusterWoningBuilder("qaj9o3", 1105, -845)
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
            new ClusterWoningBuilder("s0ehem", 2000, 1600)
                .WithAantalWoonlagen(AantalWoonlagen.Twee)
                .WithWoningType(WoningType.HoekWoning)
                .WithGezinsSituatie(Gezinssituatie.Alleenstaand)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Geen)
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("l4yayf", 1300, -583)
                .WithAantalWoonlagen(AantalWoonlagen.Drie)
                .WithWoningType(WoningType.TussenWoning)
                .WithGezinsSituatie(Gezinssituatie.TweePersonen)
                .WithOpenHaard(GebruikOpenHaard.Nee)
                .WithIsolatieMaatregelen(IsolatieMaatregelen.Kruipruimte)
                .Build()
        );
        _clusterWoningen.Add(
            new ClusterWoningBuilder("jst3ug", 1123, 3508)
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
            new ClusterWoningBuilder("uwin5s", 1387, 3249)
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
            new ClusterWoningBuilder("8nyg0s", 764, 2151)
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
            new ClusterWoningBuilder("ycnm5x", 1400, 1300)
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
            new ClusterWoningBuilder("r0wpu6", 1030, 1669)
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
            new ClusterWoningBuilder("w4i572", 1368, 631)
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
    }
}
