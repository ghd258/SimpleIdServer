// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OpenID.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UserInfoErrorsFeature : Xunit.IClassFixture<UserInfoErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UserInfoErrors.feature"
#line hidden
        
        public UserInfoErrorsFeature(UserInfoErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UserInfoErrors", "\tCheck the errors returned by the UserInfo endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing (HTTP GET)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing (HTTP GET)")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissingHTTPGET()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing (HTTP GET)", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table234 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 5
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table234, "When ");
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing (HTTP POST + FORMURLENCODED)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing (HTTP POST + FORMURLENCODED)")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissingHTTPPOSTFORMURLENCODED()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing (HTTP POST + FORMURLENCODED)", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table235 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 14
 testRunner.When("execute HTTP POST request \'http://localhost/userinfo\'", ((string)(null)), table235, "When ");
#line 17
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the token is missing (HTTP POST + JSON)")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the token is missing (HTTP POST + JSON)")]
        public virtual void ErrorIsReturnedWhenTheTokenIsMissingHTTPPOSTJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the token is missing (HTTP POST + JSON)", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table236 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 23
 testRunner.When("execute HTTP POST JSON request \'http://localhost/userinfo\'", ((string)(null)), table236, "When ");
#line 26
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("JSON \'error_description\'=\'the content-type is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token is incorrect")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token is incorrect")]
        public virtual void ErrorIsReturnedWhenTokenIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token is incorrect", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table237 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table237.AddRow(new string[] {
                        "Authorization",
                        "Bearer tst tst"});
#line 32
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table237, "When ");
#line 36
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
 testRunner.Then("JSON \'error_description\'=\'missing token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token is not well formatted")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token is not well formatted")]
        public virtual void ErrorIsReturnedWhenTokenIsNotWellFormatted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token is not well formatted", null, ((string[])(null)));
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table238 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table238.AddRow(new string[] {
                        "Authorization",
                        "Bearer tst"});
#line 42
 testRunner.When("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table238, "When ");
#line 46
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.Then("JSON \'error\'=\'invalid_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.Then("JSON \'error_description\'=\'bad token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the user is unknown")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the user is unknown")]
        public virtual void ErrorIsReturnedWhenTheUserIsUnknown()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the user is unknown", null, ((string[])(null)));
#line 51
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table239 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table239.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table239.AddRow(new string[] {
                        "scope",
                        "email"});
#line 52
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table239, "When ");
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table240 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table240.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 60
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table240, "And ");
#line hidden
            TechTalk.SpecFlow.Table table241 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table241.AddRow(new string[] {
                        "sub",
                        "unknown"});
            table241.AddRow(new string[] {
                        "aud",
                        "aud"});
#line 64
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table241, "And ");
#line hidden
            TechTalk.SpecFlow.Table table242 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table242.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 69
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table242, "And ");
#line 73
 testRunner.Then("HTTP status code equals to \'401\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when there is not valid audience in the token")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when there is not valid audience in the token")]
        public virtual void ErrorIsReturnedWhenThereIsNotValidAudienceInTheToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when there is not valid audience in the token", null, ((string[])(null)));
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table243 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table243.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table243.AddRow(new string[] {
                        "scope",
                        "email"});
#line 76
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table243, "When ");
#line 81
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table244 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table244.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 84
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table244, "And ");
#line hidden
            TechTalk.SpecFlow.Table table245 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table245.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table245.AddRow(new string[] {
                        "aud",
                        "aud"});
#line 88
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table245, "And ");
#line hidden
            TechTalk.SpecFlow.Table table246 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table246.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 93
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table246, "And ");
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 100
 testRunner.Then("JSON \'error\'=\'invalid_client\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("JSON \'error_description\'=\'invalid audiences\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when no consent has been accepted")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when no consent has been accepted")]
        public virtual void ErrorIsReturnedWhenNoConsentHasBeenAccepted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when no consent has been accepted", null, ((string[])(null)));
#line 103
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table247 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table247.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table247.AddRow(new string[] {
                        "scope",
                        "email"});
#line 104
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table247, "When ");
#line 109
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table248 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table248.AddRow(new string[] {
                        "SIG",
                        "1",
                        "ES256"});
#line 112
 testRunner.And("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table248, "And ");
#line hidden
            TechTalk.SpecFlow.Table table249 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table249.AddRow(new string[] {
                        "sub",
                        "administrator"});
            table249.AddRow(new string[] {
                        "aud",
                        "$client_id$"});
            table249.AddRow(new string[] {
                        "scope",
                        "[openid,profile]"});
#line 116
 testRunner.And("use \'1\' JWK from \'jwks\' to build JWS and store into \'accesstoken\'", ((string)(null)), table249, "And ");
#line hidden
            TechTalk.SpecFlow.Table table250 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table250.AddRow(new string[] {
                        "Authorization",
                        "Bearer $accesstoken$"});
#line 122
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table250, "And ");
#line 126
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.Then("JSON \'error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
 testRunner.Then("JSON \'error_description\'=\'no consent has been accepted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="If access token is rejected then userinfo endpoint cannot be accessed")]
        [Xunit.TraitAttribute("FeatureTitle", "UserInfoErrors")]
        [Xunit.TraitAttribute("Description", "If access token is rejected then userinfo endpoint cannot be accessed")]
        public virtual void IfAccessTokenIsRejectedThenUserinfoEndpointCannotBeAccessed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("If access token is rejected then userinfo endpoint cannot be accessed", null, ((string[])(null)));
#line 132
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table251 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table251.AddRow(new string[] {
                        "SIG",
                        "1",
                        "RS256"});
#line 133
 testRunner.When("add JSON web key to Authorization Server and store into \'jwks\'", ((string)(null)), table251, "When ");
#line hidden
            TechTalk.SpecFlow.Table table252 = new TechTalk.SpecFlow.Table(new string[] {
                        "Type",
                        "Kid",
                        "AlgName"});
            table252.AddRow(new string[] {
                        "ENC",
                        "2",
                        "RSA1_5"});
#line 137
 testRunner.And("build JSON Web Keys, store JWKS into \'jwks\' and store the public keys into \'jwks_" +
                    "json\'", ((string)(null)), table252, "And ");
#line hidden
            TechTalk.SpecFlow.Table table253 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table253.AddRow(new string[] {
                        "redirect_uris",
                        "[https://web.com]"});
            table253.AddRow(new string[] {
                        "grant_types",
                        "[implicit,authorization_code]"});
            table253.AddRow(new string[] {
                        "response_types",
                        "[token,id_token,code]"});
            table253.AddRow(new string[] {
                        "scope",
                        "email role"});
            table253.AddRow(new string[] {
                        "subject_type",
                        "public"});
            table253.AddRow(new string[] {
                        "id_token_signed_response_alg",
                        "RS256"});
            table253.AddRow(new string[] {
                        "id_token_encrypted_response_alg",
                        "RSA1_5"});
            table253.AddRow(new string[] {
                        "id_token_encrypted_response_enc",
                        "A256CBC-HS512"});
            table253.AddRow(new string[] {
                        "jwks",
                        "$jwks_json$"});
            table253.AddRow(new string[] {
                        "token_endpoint_auth_method",
                        "client_secret_post"});
#line 141
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table253, "When ");
#line 154
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And("extract parameter \'client_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.And("extract parameter \'client_secret\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And("add user consent : user=\'administrator\', scope=\'email role\', clientId=\'$client_id" +
                    "$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table254 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table254.AddRow(new string[] {
                        "response_type",
                        "id_token token code"});
            table254.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table254.AddRow(new string[] {
                        "state",
                        "state"});
            table254.AddRow(new string[] {
                        "response_mode",
                        "query"});
            table254.AddRow(new string[] {
                        "scope",
                        "openid email role"});
            table254.AddRow(new string[] {
                        "redirect_uri",
                        "https://web.com"});
            table254.AddRow(new string[] {
                        "ui_locales",
                        "en fr"});
#line 159
 testRunner.And("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table254, "And ");
#line 169
 testRunner.And("extract \'id_token\' from callback", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
 testRunner.And("extract \'code\' from callback", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table255 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table255.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table255.AddRow(new string[] {
                        "client_secret",
                        "$client_secret$"});
            table255.AddRow(new string[] {
                        "grant_type",
                        "authorization_code"});
            table255.AddRow(new string[] {
                        "code",
                        "$code$"});
            table255.AddRow(new string[] {
                        "redirect_uri",
                        "https://web.com"});
#line 172
 testRunner.And("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table255, "And ");
#line 180
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table256 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table256.AddRow(new string[] {
                        "client_id",
                        "$client_id$"});
            table256.AddRow(new string[] {
                        "client_secret",
                        "$client_secret$"});
            table256.AddRow(new string[] {
                        "grant_type",
                        "authorization_code"});
            table256.AddRow(new string[] {
                        "code",
                        "$code$"});
            table256.AddRow(new string[] {
                        "redirect_uri",
                        "https://web.com"});
#line 183
 testRunner.And("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table256, "And ");
#line hidden
            TechTalk.SpecFlow.Table table257 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table257.AddRow(new string[] {
                        "Authorization",
                        "Bearer $access_token$"});
#line 191
 testRunner.And("execute HTTP GET request \'http://localhost/userinfo\'", ((string)(null)), table257, "And ");
#line 195
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 198
 testRunner.Then("JSON \'error\'=\'invalid_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 199
 testRunner.Then("JSON \'error_description\'=\'access token has been rejected\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UserInfoErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UserInfoErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
