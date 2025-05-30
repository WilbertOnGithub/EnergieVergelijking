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
    }
}
