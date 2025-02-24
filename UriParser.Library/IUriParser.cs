using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.UriParser
{
    [OSInterface(
        Name = "UriParser",
        Description = "Parse an Uri",
        IconResourceName = "Without.Systems.UriParser.Resources.UriParser.png")]
    public interface IUriParser
    {
        
        [OSAction(
            Description = "Parses a given Uri",
            ReturnName = "result",
            ReturnType = OSDataType.InferredFromDotNetType,
            ReturnDescription = "Parsed Uri",
            IconResourceName = "Without.Systems.UriParser.Resources.UriParser.png")]
        Structures.Uri Parse(
            [OSParameter(Description = "Uri", DataType = OSDataType.Text)]
            string uriString);
    }
}