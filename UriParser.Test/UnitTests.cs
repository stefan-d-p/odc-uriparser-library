using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace Without.Systems.UriParser.Test;

public class Tests
{
    private static readonly IUriParser _actions = new UriParser();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ParseBasic()
    {
        var result = _actions.Parse("https://without.systems/myarticles?productId=3");
        Assert.That(result.Scheme, Is.EqualTo("https"));
        Assert.That(result.Host, Is.EqualTo("without.systems"));
        Assert.That(result.LocalPath, Is.EqualTo("/myarticles"));
        Assert.That(result.Query, Is.EqualTo("?productId=3"));
        Assert.That(result.IsDefaultPort, Is.True);
        
        
    }

    [Test]
    public void ParsePortOther()
    {
        var result = _actions.Parse("https://without.systems:8080/myarticles?productId=3");
        Assert.That(result.Port, Is.EqualTo(8080));
    }

   
}