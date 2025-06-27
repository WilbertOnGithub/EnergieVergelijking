using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart : ComponentBase
{
    private List<ClusterWoningDto> Woningen { get; set; } = [];

    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();

    protected override void OnInitialized()
    {
        Woningen.Add(new ClusterWoningDto("foo", 1000, 2000));
    }

    protected override void OnParametersSet()
    {
        //Console.WriteLine(FilterSelection);
    }
}
