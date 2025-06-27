using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Filter : ComponentBase
{
    private IsolatieMaatregelenDto SelectedIsolatieMaatregelen { get; set; }

    private SearchFilterDto SelectedFilterDto { get; set; } = new();

    private void ToggleIsolatieMaatregel(IsolatieMaatregelenDto maatregel)
    {
        var currentSelection = SelectedFilterDto.IsolatieMaatregelen ?? IsolatieMaatregelenDto.Geen;

        // Toggle the selected measure
        currentSelection ^= maatregel;

        SelectedFilterDto.IsolatieMaatregelen = currentSelection == IsolatieMaatregelenDto.Geen ? null : currentSelection;
    }
}
