﻿Feature: DPOPErrors
	Check errors returned when validating the DPOP Proof

Scenario: at least one DPoP header must be passed
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_request'
	And JSON '$.error_description'='the DPOP Proof is missing'

Scenario: only one DPoP header must be passed
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | value1             |
	| DPoP          | value2             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_request'
	And JSON '$.error_description'='too many DPoP parameters are passed in the header'

Scenario: DPoP header is not a JWT
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | value1             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_dpop_proof'
	And JSON '$.error_description'='DPoP Proof must be a Json Web Token'

Scenario: htm parameter is required
	Given build DPoP proof
	| Key | Value |
	
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | $DPOP$             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_dpop_proof'
	And JSON '$.error_description'='the parameter htm is missing'

Scenario: htu parameter is required
	Given build DPoP proof
	| Key | Value |
	| htm | htm   |
	
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | $DPOP$             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_dpop_proof'
	And JSON '$.error_description'='the parameter htu is missing'

Scenario: htm parameter must match the HTTP method of the current request
	Given build DPoP proof
	| Key | Value |
	| htm | GET   |
	| htu | htu   |
	
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | $DPOP$             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_dpop_proof'
	And JSON '$.error_description'='the htm parameter must be equals to POST'

Scenario: htu parameter must match the HTTP URI value for the HTTP request in which the JWT was received
	Given build DPoP proof
	| Key | Value |
	| htm | POST  |
	| htu | htu   |
	
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | $DPOP$             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_dpop_proof'
	And JSON '$.error_description'='the htu parameter must be equals to https://localhost:8080/token'

Scenario: DPoP proof cannot have a lifetime superior to the limit
	Given build DPoP proof with big lifetime
	| Key | Value                          |
	| htm | POST                           |
	| htu | https://localhost:8080/token   |
	
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key           | Value              |
	| grant_type    | client_credentials |
	| scope         | firstScope         |
	| client_id     | sixtyThreeClient   |
	| client_secret | password           |
	| DPoP          | $DPOP$             |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_dpop_proof'
	And JSON '$.error_description'='the DPoP cannot have a validity superior to 300 seconds'