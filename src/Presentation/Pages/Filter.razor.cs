using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Filter : ComponentBase
{
    private IsolatieMaatregelenDto SelectedIsolatieMaatregelen { get; set; }

    private SearchFilterDto SelectedFilterDto { get; set; } = new();

    private void ToggleIsolatieMaatregel(IsolatieMaatregelenDto maatregel)
    {
        // Start with the current selection, or 'Geen' if null
        var currentSelection = SelectedFilterDto.IsolatieMaatregelen ?? IsolatieMaatregelenDto.Geen;

        // Toggle the selected measure
        currentSelection ^= maatregel;

        // If the result is 'Geen', set the DTO property to null to indicate no filter is applied.
        // Otherwise, update it with the new combined value.
        SelectedFilterDto.IsolatieMaatregelen = currentSelection == IsolatieMaatregelenDto.Geen ? null : currentSelection;
    }
}
