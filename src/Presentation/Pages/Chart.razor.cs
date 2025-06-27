using System.Diagnostics.CodeAnalysis;
using System.Globalization;

using ApexCharts;

using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart(Searcher searcher) : ComponentBase
{
    private const string PowerColor = "orange";
    private const string GasColor = "darkblue";
    private readonly CultureInfo dutchCulture = new("en-NL");

    private ApexChart<ClusterWoningDto>? chart;
    private readonly ApexChartOptions<ClusterWoningDto> options = new();

    private IReadOnlyList<ClusterWoningDto> Woningen { get; set; } = [];

    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();

    protected override void OnInitialized()
    {
        options.Colors = [PowerColor, GasColor];
    }

    protected override async Task OnParametersSetAsync()
    {
        Woningen = searcher.Search(FilterSelection);
        var averageKwh = Woningen.Any() ? (decimal)Woningen.Average(w => w.KiloWattUur) : 0;
        var averageGasUsage = Woningen.Any() ? (decimal)Woningen.Average(w => w.KubiekeMeterGas) : 0;

        options.Annotations = new Annotations
        {
            Yaxis =
            [
                new AnnotationsYAxis
                {
                    Y = averageKwh,
                    BorderWidth = 2,
                    BorderColor = PowerColor,
                    StrokeDashArray = 2,
                    Label = new Label
                    {
                        BorderColor = PowerColor,
                        Style = new Style {Color = "black", Background = PowerColor},
                        Text = $"Gemiddeld stroomverbruik: {averageKwh.ToString("N0", dutchCulture)} kWh"
                    }
                },
                new AnnotationsYAxis
                {
                    Y = averageGasUsage,
                    BorderColor = GasColor,
                    StrokeDashArray = 2,
                    Label = new Label
                    {
                        BorderColor = GasColor,
                        Style = new Style {Color = "white", Background = GasColor},
                        Text = $"Gemiddeld gasverbruik: {averageGasUsage.ToString("N0", dutchCulture)} m2"
                    }
                }
            ]
        };

        if (chart != null)
        {
            await chart.UpdateSeriesAsync();
            await chart.UpdateOptionsAsync(redrawPaths: true, animate: true, updateSyncedCharts: true);
        }
    }
}
