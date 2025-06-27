using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart : ComponentBase
{
    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();
}
