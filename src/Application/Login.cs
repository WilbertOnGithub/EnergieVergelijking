using Arentheym.EnergieVergelijker;
using Arentheym.EnergieVergelijker.Domain;

namespace Application;

public class Login
{
    private readonly Vergelijker _vergelijker = new();
    private readonly ClusterWoningMapper _clusterWoningMapper = new();
    private readonly SearchFilterMapper _searchFilterMapper = new();

    public bool CodeExists(string code)
    {
        return _vergelijker.CodeExists(code);
    }

    public IReadOnlyList<ClusterWoningDto> Search(SearchFilterDto searchFilterDto)
    {
        SearchFilter searchFilter = _searchFilterMapper.SearchFilterDtoToSearchFilter(searchFilterDto);

        IReadOnlyList<ClusterWoning> searchResult = _vergelijker.Search(searchFilter);
        return searchResult.Select(x => _clusterWoningMapper.ClusterWoningToClusterWoningDto(x)).ToList();
    }
}
