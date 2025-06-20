using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

#pragma warning disable CA1515
public partial class Login : ComponentBase
#pragma warning restore CA1515
{
    public string UniqueCode { get; set; } = string.Empty;

    private void HandleSubmit()
    {
        Console.WriteLine($"Received text input: {UniqueCode}");
    }
}
