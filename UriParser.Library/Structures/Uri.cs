using System.Security.Cryptography;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.UriParser.Structures;

[OSStructure(Description = "Uri")]
public struct Uri
{
    [OSStructureField(Description = "Absolute Path", DataType = OSDataType.Text)]
    public string AbsolutePath;
    
    [OSStructureField(Description = "Absolute Uri", DataType = OSDataType.Text)]
    public string AbsoluteUri;
    
    [OSStructureField(Description = "Local Path", DataType = OSDataType.Text)]
    public string LocalPath;
    
    [OSStructureField(Description = "Authority", DataType = OSDataType.Text)]
    public string Authority;
    
    [OSStructureField(Description = "Is Default Port", DataType = OSDataType.Boolean)]
    public bool IsDefaultPort;
    
    [OSStructureField(Description = "Is File", DataType = OSDataType.Boolean)]
    public bool IsFile;
    
    [OSStructureField(Description = "Is Loopback", DataType = OSDataType.Boolean)]
    public bool IsLoopback;
    
    [OSStructureField(Description = "Is Unc", DataType = OSDataType.Boolean)]
    public bool IsUnc;

    [OSStructureField(Description = "Escaped Absolute Path and Query separated by ?", DataType = OSDataType.Text)]
    public string PathAndQuery;
    
    [OSStructureField(Description = "Array of the segments that make up a URI", DataType = OSDataType.InferredFromDotNetType)]
    public List<string> Segments;
    
    [OSStructureField(Description = "Host", DataType = OSDataType.Text)]
    public string Host;
    
    [OSStructureField(Description = "Port", DataType = OSDataType.Integer)]
    public int Port;
    
    [OSStructureField(Description = "Scheme", DataType = OSDataType.Text)]
    public string Scheme;
    
    [OSStructureField(Description = "Query", DataType = OSDataType.Text)]
    public string Query;
    
    [OSStructureField(Description = "Fragment", DataType = OSDataType.Text)]
    public string Fragment;
    
    [OSStructureField(Description = "User Info", DataType = OSDataType.Text)]
    public string UserInfo;
    
}