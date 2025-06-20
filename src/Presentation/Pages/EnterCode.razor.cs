using Microsoft.AspNetCore.Components;

namespace Presentation.Pages;

public partial class EnterCode : ComponentBase
{
    [Inject]
    public required Application.Login Login { get; set; }

    [Inject]
    public required NavigationManager Navigation { get; set; }

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
