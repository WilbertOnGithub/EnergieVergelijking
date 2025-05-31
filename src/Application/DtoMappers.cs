using Arentheym.EnergieVergelijker.Domain;

using Riok.Mapperly.Abstractions;

namespace Arentheym.EnergieVergelijker;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByValue)]
public partial class ClusterWoningMapper
{
    public partial ClusterWoningDto ClusterWoningToClusterWoningDto(ClusterWoning clusterWoning);
}

[Mapper]
public partial class SearchFilterMapper
{
    public partial SearchFilter SearchFilterDtoToSearchFilter(SearchFilterDto searchFilterDto);

    [MapProperty(nameof(SearchFilterDto.KiloWattUur), nameof(SearchFilter.KiloWattUur), Use = nameof(MapTupleToRange))]
    [MapProperty(nameof(SearchFilterDto.KubiekeMeterGas), nameof(SearchFilter.KubiekeMeterGas), Use = nameof(MapTupleToRange))]
    private static Range<int>? MapTupleToRange((int min, int max)? tuple)
    {
        return tuple is not null ? new Range<int>(tuple.Value.min, tuple.Value.max) : null;
    }
}
