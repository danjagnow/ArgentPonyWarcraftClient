﻿using System.Text.Json.Serialization;

namespace ArgentPonyWarcraftClient
{
    /// <summary>
    /// A subcategory of items.
    /// </summary>
    public class ItemSubclass
    {
        /// <summary>
        /// Gets links for the item subclass.
        /// </summary>
        [JsonPropertyName("_links")]
        public Links Links { get; set; }

        /// <summary>
        /// Gets the class ID for the item class.
        /// </summary>
        [JsonPropertyName("class_id")]
        public long ClassId { get; set; }

        /// <summary>
        /// Gets the subclass ID for the item subclass.
        /// </summary>
        [JsonPropertyName("subclass_id")]
        public long SubclassId { get; set; }

        /// <summary>
        /// Gets the display name of the item subclass.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets a value indicating whether the subclass is hidden in tooltips.
        /// </summary>
        [JsonPropertyName("hide_subclass_in_tooltips")]
        public bool HideSubclassInTooltips { get; set; }
    }
}
