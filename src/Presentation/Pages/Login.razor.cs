using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class Login : ComponentBase
{
    public string UniqueCode { get; set; } = string.Empty;

    private void HandleSubmit()
    {
        Console.WriteLine($"Received text input: {UniqueCode}");
    }
}
