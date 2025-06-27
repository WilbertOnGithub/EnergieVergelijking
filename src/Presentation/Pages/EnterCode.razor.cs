using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class EnterCode(NavigationManager navigationManager, Application.Login login) : ComponentBase
{
    private string Code { get; set; } = string.Empty;
    private string ErrorMessage { get; set; } = string.Empty;

    private void HandleSubmit()
    {
        if (string.IsNullOrWhiteSpace(Code))
        {
            ErrorMessage = "Uw code is leeg.";
            return;
        }
        if (!login.CodeExists(Code))
        {
            ErrorMessage = "Onbekende code.";
            return;
        }

        navigationManager.NavigateTo("/filter/");
    }

    private void HandleReset()
    {
        ErrorMessage = string.Empty;
        Code = string.Empty;
    }
}
