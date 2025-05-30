namespace Arentheym.EnergieVergelijker.Domain;

/// <summary>
/// Builder pattern for ClusterWoning
/// </summary>
public class ClusterWoningBuilder(string code, int kiloWattUur, int kubiekeMeterGas)
{
    private readonly ClusterWoning _clusterWoning = new(code, kiloWattUur, kubiekeMeterGas);

    public ClusterWoningBuilder WithWoningType(WoningType woningType)
    {
        _clusterWoning.WoningType = woningType;
        return this;
    }

    public ClusterWoningBuilder WithAantalWoonlagen(AantalWoonlagen aantalWoonlagen)
    {
        _clusterWoning.AantalWoonlagen = aantalWoonlagen;
        return this;
    }

    public ClusterWoningBuilder WithGezinsSituatie(Gezinssituatie gezinssituatie)
    {
        _clusterWoning.Gezinssituatie = gezinssituatie;
        return this;
    }

    public ClusterWoningBuilder WithOpenHaard(GebruikOpenHaard gebruikOpenHaard)
    {
        _clusterWoning.GebruikOpenHaard = gebruikOpenHaard;
        return this;
    }

    public ClusterWoningBuilder WithIsolatieMaatregelen(IsolatieMaatregelen isolatieMaatregelen)
    {
        _clusterWoning.IsolatieMaatregelen = isolatieMaatregelen;
        return this;
    }

    public ClusterWoningBuilder WithCommentaar(string commentaar)
    {
        _clusterWoning.Commentaar = commentaar;
        return this;
    }

    public ClusterWoning Build()
    {
        return _clusterWoning;
    }
}
