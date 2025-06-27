using System.Diagnostics.CodeAnalysis;

using ApexCharts;

using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart(Login login) : ComponentBase
{
    private ApexChart<ClusterWoningDto>? chart;

    private IReadOnlyList<ClusterWoningDto> Woningen { get; set; } = [];

    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();

    protected override void OnInitialized()
    {
        Woningen = login.Search(FilterSelection);
    }

    protected override async Task OnParametersSetAsync()
    {
        Woningen = login.Search(FilterSelection);
        if (chart != null)
        {
            await chart.UpdateSeriesAsync();
        }
    }
}
