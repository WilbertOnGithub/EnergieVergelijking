using System.Diagnostics.CodeAnalysis;

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
    private readonly IFixture _fixture;

    private MapperTests()
    {
        _fixture = new Fixture().Customize(new AutoNSubstituteCustomization());
    }

    [Fact]
    public void SearchFilterDto_To_SearchFilter_Should_Map_Correctly()
    {

    }
}
