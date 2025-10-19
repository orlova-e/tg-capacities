using Capacities.Api.Client.Configuration;
using Capacities.Api.Client.Dto;
using Flurl.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Capacities.Api.Client.Implementation;

internal class CapacitiesClient : ICapacitiesClient
{
    private readonly IOptions<CapacitiesApiOptions> _capacitiesApiOptions;
    private readonly ILogger<CapacitiesClient> _logger;
    private readonly IFlurlRequest _request;

    public CapacitiesClient(IOptions<CapacitiesApiOptions> capacitiesApiOptions,
        ILogger<CapacitiesClient> logger)
    {
        _capacitiesApiOptions = capacitiesApiOptions;
        _logger = logger;
        _request = _capacitiesApiOptions.Value.Host
            .WithOAuthBearerToken(_capacitiesApiOptions.Value.BearerToken);
    }

    #region GENERAL
    public async Task<GetAllSpacesDto> GetAllSpacesAsync(CancellationToken token)
    {
        try
        {
            var request = _request.AppendPathSegment(_capacitiesApiOptions.Value.GetSpaces);
            
            var result = await request.GetJsonAsync<GetAllSpacesDto>(HttpCompletionOption.ResponseContentRead, token);
            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Can't get all spaces");
            throw;
        }
    }

    public async Task<GetAllStructuresDto> GetStructuresAsync(Guid spaceId, CancellationToken token)
    {
        try
        {
            var request = _request.AppendPathSegment(_capacitiesApiOptions.Value.GetStructures);
            
            var result = await request.GetJsonAsync<GetAllStructuresDto>(HttpCompletionOption.ResponseContentRead, token);
            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Can't get all spaces");
            throw;
        }
    }
    #endregion
    
    #region CONTENT
    public async Task<GetAllSearchDto> SearchContentAsync(IEnumerable<Guid> spaceIds, string searchText, CancellationToken token)
    {
        var searchDto = new PostSearchDto()
        {
            SpaceIds = spaceIds.Select(x => x.ToString()),
            SearchTerm = searchText
        };
        
        try
        {
            var request = _request.AppendPathSegment(_capacitiesApiOptions.Value.SearchInSpaces);
            
            var result = await request.PostJsonAsync(searchDto, HttpCompletionOption.ResponseContentRead, token);
            var dto = await result.GetJsonAsync<GetAllSearchDto>();
            return dto;
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Can't get all spaces");
            throw;
        }
    }

    public async Task SaveToDailyNoteAsync(string spaceId, string markdown, CancellationToken token)
    {
        throw new NotImplementedException();
    }
    #endregion
}