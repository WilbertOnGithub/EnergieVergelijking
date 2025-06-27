using Arentheym.EnergieVergelijker.Application;

using Microsoft.AspNetCore.Components;

namespace Arentheym.EnergieVergelijker.Presentation.Pages;

public partial class Filter : ComponentBase
{
    private WoningTypeDto? SelectedWoningType { get; set; }

    private AantalWoonlagenDto? SelectedAantalWoonlagen { get; set; }

    private GebruikOpenHaardDto? SelectedGebruikOpenHaard { get; set; }
}
