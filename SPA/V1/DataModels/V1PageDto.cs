﻿using Newtonsoft.Json;

namespace SPA.V1.DataModels;

public sealed class V1PageDto<T>
{
    [JsonProperty("items")]
    public ICollection<T> Items { get; init; }

    [JsonProperty("totalCount")]
    public long TotalCount { get; init; }

    [JsonProperty("hasPrevious")]
    public bool HasPrevious { get; init; }
    
    [JsonProperty("hasNext")]
    public bool HasNext { get; init; }
}