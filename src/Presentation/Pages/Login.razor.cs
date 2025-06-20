using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class Login : ComponentBase
{
    public string UniqueCode { get; set; } = string.Empty;
    public string ErrorMessage { get; set; } = string.Empty;

    private void HandleSubmit()
    {
        if (string.IsNullOrWhiteSpace(UniqueCode))
        {
            ErrorMessage = "Uw code is leeg.";
        }
    }
}
