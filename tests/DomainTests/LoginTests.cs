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
public class LoginTests
{
    [Fact]
    public void Using_Unknown_Code_Returns_False()
    {
        // Arrange
        var vergelijker = new Vergelijker();

        // ACT
        bool result = vergelijker.CodeExists(Guid.NewGuid().ToString());

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void Using_Known_Code_Returns_True()
    {
        // Arrange
        var vergelijker = new Vergelijker();

        // ACT
        bool result = vergelijker.CodeExists("n5lvbv");

        // Assert
        result.Should().BeTrue();
    }
}
