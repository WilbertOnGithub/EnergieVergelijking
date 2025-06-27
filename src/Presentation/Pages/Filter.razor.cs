using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Filter : ComponentBase
{
    private WoningTypeDto? SelectedWoningType { get; set; }

    private AantalWoonlagenDto? SelectedAantalWoonlagen { get; set; }

    private GebruikOpenHaardDto? SelectedGebruikOpenHaard { get; set; }

    private GezinssituatieDto? SelectedGezinsSituatie { get; set; }

    private IsolatieMaatregelenDto SelectedIsolatieMaatregelen { get; set; }

    private void ToggleIsolatieMaatregel(IsolatieMaatregelenDto maatregel)
    {
        SelectedIsolatieMaatregelen ^= maatregel;
    }
}
