﻿using System.Threading.Tasks;
using ArgentPonyWarcraftClient.GameData;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    ///     A client for the World of Warcraft Journal API.
    /// </summary>
    public interface IWarcraftClientJournalApi
    {
        /// <summary>
        ///     Get the journal expansions index.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <returns>
        ///     The journal expansions index.
        /// </returns>
        Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace);

        /// <summary>
        ///     Get the journal expansions index.
        /// </summary>
        /// <param name="namespace">The namespace to use to locate this document.</param>
        /// <param name="region">Specifies the region that the API will retrieve its data from.</param>
        /// <param name="locale">Specifies the language that the result will be in.</param>
        /// <returns>
        ///     The journal expansions index.
        /// </returns>
        Task<RequestResult<JournalExpansionsIndex>> GetJournalExpansionsIndexAsync(string @namespace, Region region, Locale locale);
    }
}