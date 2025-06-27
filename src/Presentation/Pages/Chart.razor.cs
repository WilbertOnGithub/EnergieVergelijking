using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart(Login login) : ComponentBase
{
    private IReadOnlyList<ClusterWoningDto> Woningen { get; set; } = [];

    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();

    protected override void OnInitialized()
    {
        Woningen = login.Search(FilterSelection);
    }

    protected override void OnParametersSet()
    {
        //Console.WriteLine(FilterSelection);
    }
}
