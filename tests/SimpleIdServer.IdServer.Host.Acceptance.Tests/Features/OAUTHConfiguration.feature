﻿Feature: OAuthConfiguration
	Get the OAUTHConfiguration and check its content

Scenario: Get the configuration
	When execute HTTP GET request 'https://localhost:8080/.well-known/oauth-authorization-server'
	| Key | Value |
	And extract JSON from body

	Then HTTP status code equals to '200'
	And JSON 'issuer'='https://localhost:8080'
	And JSON 'authorization_endpoint'='https://localhost:8080/authorization'
	And JSON 'registration_endpoint'='https://localhost:8080/register'
	And JSON 'token_endpoint'='https://localhost:8080/token'
	And JSON 'revocation_endpoint'='https://localhost:8080/token/revoke'
	And JSON 'jwks_uri'='https://localhost:8080/jwks'
	And JSON 'tls_client_certificate_bound_access_tokens'='true'
	And JSON '$.response_types_supported[0]'='code'
	And JSON '$.response_types_supported[1]'='code id_token'
	And JSON '$.response_types_supported[2]'='code id_token token'
	And JSON '$.response_types_supported[3]'='code token'
	And JSON '$.response_types_supported[4]'='id_token'
	And JSON '$.response_types_supported[5]'='id_token token'
	And JSON '$.response_modes_supported[0]'='query'
	And JSON '$.response_modes_supported[1]'='fragment'
	And JSON '$.response_modes_supported[2]'='form_post'
	And JSON '$.scopes_supported[0]'='firstScope'
	And JSON '$.scopes_supported[1]'='secondScope'
	And JSON '$.grant_types_supported[0]'='client_credentials'
	And JSON '$.grant_types_supported[1]'='refresh_token'
	And JSON '$.grant_types_supported[2]'='password'
	And JSON '$.grant_types_supported[3]'='authorization_code'
	And JSON '$.grant_types_supported[4]'='urn:openid:params:grant-type:ciba'
	And JSON '$.grant_types_supported[5]'='urn:ietf:params:oauth:grant-type:uma-ticket'
	And JSON '$.grant_types_supported[6]'='implicit'
	And JSON '$.token_endpoint_auth_methods_supported[0]'='private_key_jwt'
	And JSON '$.token_endpoint_auth_methods_supported[1]'='client_secret_basic'
	And JSON '$.token_endpoint_auth_methods_supported[2]'='client_secret_jwt'
	And JSON '$.token_endpoint_auth_methods_supported[3]'='client_secret_post'
	And JSON '$.token_endpoint_auth_methods_supported[4]'='pkce'
	And JSON '$.token_endpoint_auth_methods_supported[5]'='tls_client_auth'
	And JSON '$.token_endpoint_auth_methods_supported[6]'='self_signed_tls_client_auth'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[0]'='ES256'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[1]'='ES384'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[2]'='ES512'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[3]'='HS256'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[4]'='HS384'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[5]'='HS512'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[6]'='PS256'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[7]'='PS384'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[8]'='PS512'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[9]'='RS256'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[10]'='RS384'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[11]'='RS512'
	And JSON '$.token_endpoint_auth_signing_alg_values_supported[12]'='none'