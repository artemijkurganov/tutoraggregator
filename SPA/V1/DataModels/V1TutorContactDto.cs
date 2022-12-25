﻿using System.Text.Json.Serialization;
using SPA.Models;

namespace SPA.V1.DataModels;

public sealed class V1TutorContactDto
{
    [JsonPropertyName("id")]
    public string Id { get; init; }
    
    [JsonPropertyName("type")]
    public ContactType Type { get; init; }

    [JsonPropertyName("value")]
    public string Value { get; init; }
}