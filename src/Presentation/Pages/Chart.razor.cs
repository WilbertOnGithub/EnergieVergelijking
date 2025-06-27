using System.Diagnostics.CodeAnalysis;

using ApexCharts;

using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart(Searcher searcher) : ComponentBase
{
    private ApexChart<ClusterWoningDto>? chart;
    private readonly ApexChartOptions<ClusterWoningDto> options = new();

    private IReadOnlyList<ClusterWoningDto> Woningen { get; set; } = [];

    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();

    protected override void OnInitialized()
    {
        options.Colors = ["lightgray", "lightblue"];
    }

    protected override async Task OnParametersSetAsync()
    {
        Woningen = searcher.Search(FilterSelection);
        if (chart != null)
        {
            await chart.UpdateSeriesAsync();
        }
    }
}
