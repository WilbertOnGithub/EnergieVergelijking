using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class EnterCode : ComponentBase
{
    [Inject]
    private Application.Login Login { get; set; } = null!;

    [Inject]
    private NavigationManager Navigation { get; set; } = null!;

    private string Code { get; set; } = string.Empty;
    private string ErrorMessage { get; set; } = string.Empty;

    private void HandleSubmit()
    {
        if (string.IsNullOrWhiteSpace(Code))
        {
            ErrorMessage = "Uw code is leeg.";
            return;
        }
        if (!Login.CodeExists(Code))
        {
            ErrorMessage = "Onbekende code.";
            return;
        }

        Navigation.NavigateTo("/energievergelijking/");
    }

    private void HandleReset()
    {
        ErrorMessage = string.Empty;
        Code = string.Empty;
    }
}
