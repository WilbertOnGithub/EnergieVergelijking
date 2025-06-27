using System.Diagnostics.CodeAnalysis;

using Arentheym.EnergieVergelijker.Application;
using Arentheym.EnergieVergelijker.Domain;

using AutoFixture;
using AutoFixture.AutoNSubstitute;

using FluentAssertions;
using Xunit;

namespace ApplicationTests;

[SuppressMessage(
    "Naming",
    "CA1707:Identifiers should not contain underscores",
    Justification = "Unit test method naming"
)]
public class MapperTests
{
    private readonly IFixture _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());

    [Fact]
    public void SearchFilterDto_To_SearchFilter_Should_Map_Correctly()
    {
        // Arrange
        var searchFilterDto = _fixture.Create<SearchFilterDto>();
        searchFilterDto.KiloWattUur = (0, 20_000);
        searchFilterDto.KubiekeMeterGas = (0, 20_000);

        // Act
        var sut = _fixture.Create<SearchFilterMapper>();
        SearchFilter searchFilter = sut.SearchFilterDtoToSearchFilter(searchFilterDto);

        // Assert
        searchFilter.Should().BeEquivalentTo(searchFilterDto, options => options.Excluding(x => x.KiloWattUur).Excluding(x => x.KubiekeMeterGas));
    }
}
