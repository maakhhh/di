using FluentAssertions;
using TagCloud.TextSplitters;

namespace TagCloudTests.TextSpliitersTests;

[TestFixture]
public class EnterTextSplitterTests
{
    private EnterTextSplitter splitter = new();

    [Test]
    public void NotThrow_WhenEmptyText()
    {
        var action = () => splitter.Split(string.Empty);
        action.Should().NotThrow();
    }

    [Test]
    public void Throw_WhenTextIsNull()
    {
        var action = () => splitter.Split(null);
        action.Should().Throw<ArgumentNullException>();
    }

    [TestCase("a", new string[1] { "a" }, TestName = "One word")]
    [TestCase("a\nb", new string[2] { "a", "b" }, TestName = "Several words")]
    [TestCase("a\n\nb", new string[2] { "a", "b" }, TestName = "Skip empty words")]
    public void SplitTextCorrect(string text, string[] exxpectedResult)
    {
        var actualResult = splitter.Split(text).ToArray();

        actualResult.Should().BeEquivalentTo(exxpectedResult);
    }
}
