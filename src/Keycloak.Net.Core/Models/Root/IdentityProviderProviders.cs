﻿namespace Keycloak.Net.Models.Root;

public class IdentityProviderProviders
{
	[JsonPropertyName("saml")]
	public HasOrder Saml { get; set; }

	[JsonPropertyName("oidc")]
	public HasOrder Oidc { get; set; }

	[JsonPropertyName("keycloak-oidc")]
	public HasOrder KeycloakOidc { get; set; }
}