using Arentheym.EnergieVergelijker.Domain;

namespace Arentheym.EnergieVergelijker.Application;

public class Login
{
    private readonly Vergelijker _vergelijker = new();
    private readonly ClusterWoningMapper _clusterWoningMapper = new();
    private readonly SearchFilterMapper _searchFilterMapper = new();

    public string Code { get; set; } = string.Empty;

    public bool CodeExists(string code)
    {
        if (!_vergelijker.CodeExists(code))
        {
            return false;
        }

        Code = code;
        return true;
    }

    public IReadOnlyList<ClusterWoningDto> Search(SearchFilterDto searchFilterDto)
    {
        SearchFilter searchFilter = _searchFilterMapper.SearchFilterDtoToSearchFilter(searchFilterDto);

        IReadOnlyList<ClusterWoning> searchResult = _vergelijker.Search(searchFilter);
        return searchResult.Select(x => _clusterWoningMapper.ClusterWoningToClusterWoningDto(x)).ToList();
    }
}
