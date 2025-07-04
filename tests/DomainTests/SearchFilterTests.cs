using System.Diagnostics.CodeAnalysis;
using Arentheym.EnergieVergelijker.Domain;
using FluentAssertions;
using Xunit;

namespace DomainTests;

[SuppressMessage(
    "Naming",
    "CA1707:Identifiers should not contain underscores",
    Justification = "Unit test method naming"
)]
public class SearchFilterTests
{
    [Fact]
    public void Current_Dataset_Contains_Expected_Results_When_Searching_For_Glas_Isolatie_Maatregelen_Only()
    {
        // Arrange
        var sut = new Vergelijker();
        SearchFilter filter = new() { IsolatieMaatregelen = IsolatieMaatregelen.Glas };

        // Act
        var result = sut.Search(filter);

        // Assert
        result.Count.Should().Be(21);
    }

    [Fact]
    public void Empty_Filter_Should_Return_All_Results()
    {
        // Arrange
        var sut = new Vergelijker();
        SearchFilter filter = new();

        // Act
        var result = sut.Search(filter);

        // Assert
        result.Count.Should().Be(28);
    }

    [Fact]
    public void Searches_Should_Be_Inclusive()
    {
        // Arrange
        var sut = new Vergelijker();
        SearchFilter filter = new() { AantalWoonlagen = AantalWoonlagen.Twee, Gezinssituatie = Gezinssituatie.Gezin };

        // Act
        var result = sut.Search(filter);

        // Assert
        result.Count.Should().Be(6);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(20_000, 20_000)]
    public void Search_With_Extreme_KwhRange_Should_Not_Return_Results(int min, int max)
    {
        // Arrange
        var sut = new Vergelijker();
        SearchFilter filter = new() { KiloWattUur = new Range<int>(min, max) };

        // Act
        var result = sut.Search(filter);

        // Assert
        result.Count.Should().Be(0);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(20_000, 20_000)]
    public void Search_With_Extreme_GasUsage_Should_Not_Return_Results(int min, int max)
    {
        // Arrange
        var sut = new Vergelijker();
        SearchFilter filter = new() { KubiekeMeterGas = new Range<int>(min, max) };

        // Act
        var result = sut.Search(filter);

        // Assert
        result.Count.Should().Be(0);
    }

    [Theory]
    [InlineData(0, 0)]
    public void Search_With_Extreme_GasUsage_Should_Only_Return_Own_Home(int min, int max)
    {
        // Arrange
        const string code = "w4i572";

        var sut = new Vergelijker();
        SearchFilter filter = new() { KubiekeMeterGas = new Range<int>(min, max) };

        // Act
        var result = sut.Search(filter, code);

        // Assert
        result.Count.Should().Be(1);
        result[0].Code.Should().Be(code);
    }

    [Fact]
    public void Searching_Should_Put_Own_Home_First()
    {
        // Arrange
        const string code = "w4i572";

        var sut = new Vergelijker();
        SearchFilter filter = new();

        // Act
        var result = sut.Search(filter, code);

        // Assert
        result.Count.Should().Be(28);
        result[0].Code.Should().Be(code);
    }

    [Fact]
    public void Searching_Should_Put_Own_Home_First_Even_If_Own_Home_Would_Be_Filtered_Out()
    {
        // Arrange
        const string code = "n5lvbv";

        var sut = new Vergelijker();
        SearchFilter filter = new();
        filter.AantalWoonlagen = AantalWoonlagen.Drie;
        filter.GebruikOpenHaard = GebruikOpenHaard.Ja;

        // Act
        var result = sut.Search(filter, code);

        // Assert
        result[0].Code.Should().Be(code);
    }
}
