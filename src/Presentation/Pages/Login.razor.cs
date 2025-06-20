using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class Login : ComponentBase
{
    private string Code { get; set; } = string.Empty;
    private string ErrorMessage { get; set; } = string.Empty;

    private void HandleSubmit()
    {
        if (string.IsNullOrWhiteSpace(Code))
        {
            ErrorMessage = "Uw code is leeg.";
        }
    }

    private void HandleReset()
    {
        ErrorMessage = string.Empty;
        Code = string.Empty;
    }
}
