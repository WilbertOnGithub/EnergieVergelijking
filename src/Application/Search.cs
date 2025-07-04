using Arentheym.EnergieVergelijker.Domain;

namespace Arentheym.EnergieVergelijker.Application;

public class Searcher
{
    private readonly Vergelijker _vergelijker = new();
    private readonly ClusterWoningMapper _clusterWoningMapper = new();
    private readonly SearchFilterMapper _searchFilterMapper = new();

    public IReadOnlyList<ClusterWoningDto> Search(SearchFilterDto searchFilterDto, string optionalCode = "")
    {
        SearchFilter searchFilter = _searchFilterMapper.SearchFilterDtoToSearchFilter(searchFilterDto);

        IReadOnlyList<ClusterWoning> searchResult = _vergelijker.Search(searchFilter, optionalCode);
        return searchResult.Select(x => _clusterWoningMapper.ClusterWoningToClusterWoningDto(x)).ToList();
    }
}
