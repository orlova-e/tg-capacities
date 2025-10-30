using Content.Capacities.Api.Client.Dto;

namespace Content.Capacities.Api.Client;

public interface ICapacitiesClient
{
    #region GENERAL
    /// <summary>
    /// Gets all available through the token spaces
    /// </summary>
    /// <param name="token">Cancellation token</param>
    /// <returns>All spaces</returns>
    Task<GetAllSpacesDto> GetAllSpacesAsync(CancellationToken token);

    /// <summary>
    /// Gets all the type's and its collections of the space
    /// </summary>
    /// <param name="spaceId">Space id to get types in</param>
    /// <param name="token">Cancellation token</param>
    /// <returns></returns>
    Task<GetAllStructuresDto> GetStructuresAsync(Guid spaceId, CancellationToken token);
    #endregion

    #region CONTENT
    /// <summary>
    /// Searches content in required spaces
    /// </summary>
    /// <param name="spaceIds">Accessible space's ids</param>
    /// <param name="searchText">Text to search</param>
    /// <param name="token">Cancellation token</param>
    /// <returns></returns>
    Task<GetAllSearchDto> SearchContentAsync(IEnumerable<Guid> spaceIds, string searchText, CancellationToken token);

    /// <summary>
    /// Save's markdown prettified text to today's Daily note (system type)
    /// </summary>
    /// <param name="markdown">Markdown capable text</param>
    /// <param name="token">Cancellation token</param>
    /// <returns></returns>
    Task SaveToDailyNoteAsync(string spaceId, string markdown, CancellationToken token);
    #endregion
}