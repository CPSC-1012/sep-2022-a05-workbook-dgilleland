using FluentAssertions;

namespace Submariner.Specs;

public class Submarine_Should
{
    [Fact]
    public void Be_Docked_Initially()
    {
        Submarine sut = new();
        sut.IsDocked.Should().BeTrue();
    }

    [Fact]
    public void Have_Initial_Crew_Of_Zero()
    {
        Submarine sut = new();
        sut.CrewComplement.Should().Be(0);
    }

    [Fact]
    public void Have_Intial_Torpedo_Count_Of_Zero()
    {
        Submarine sut = new();
        sut.TorpedoCount.Should().Be(0);
    }

    [Fact]
    public void Be_At_Depth_Zero()
    {
        Submarine sut = new();
        sut.Depth.Should().Be(0);
    }

    [Fact]
    public void Not_Be_ReadyForLaunch_Initially()
    {
        Submarine sut = new();
        sut.IsReadyForLaunch.Should().BeFalse();
    }
}