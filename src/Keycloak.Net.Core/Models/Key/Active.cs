﻿namespace Keycloak.Net.Models.Key;

public class Active
{
	[JsonPropertyName("HS256")]
	public string Hs256 { get; set; }
	[JsonPropertyName("RS256")]
	public string Rs256 { get; set; }
	[JsonPropertyName("AES")]
	public string Aes { get; set; }
}