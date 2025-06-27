using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Chart : ComponentBase
{
    private List<MyData> Data { get; set; } = new();

    [Parameter]
    public SearchFilterDto FilterSelection { get; set; } = new();

    protected override void OnInitialized()
    {
        Data.Add(new MyData { Category = "Jan", NetProfit = 12, Revenue = 33 });
        Data.Add(new MyData { Category = "Feb", NetProfit = 43, Revenue = 42 });
        Data.Add(new MyData { Category = "Mar", NetProfit = 112, Revenue = 23 });
    }
}

public class MyData
{
    public string Category { get; set; } = string.Empty;
    public int NetProfit { get; set; }
    public int Revenue { get; set; }
}
