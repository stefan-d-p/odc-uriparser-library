using AutoMapper;
using Microsoft.Extensions.Logging.Abstractions;
using OutSystems.ExternalLibraries.SDK;

namespace Without.Systems.UriParser;

public class UriParser : IUriParser
{

    private readonly IMapper _mapper;

    public UriParser()
    {
        MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Uri, Structures.Uri>();
        }, NullLoggerFactory.Instance);
        
        _mapper = mapperConfiguration.CreateMapper();
    }
    
    public Structures.Uri Parse(string uriString)
    {
        Uri uri = new Uri(uriString);
        return _mapper.Map<Structures.Uri>(uri);
        
    }
}