﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features.GrantTypes
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ImplicitGrantTypeFeature : object, Xunit.IClassFixture<ImplicitGrantTypeFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ImplicitGrantType.feature"
#line hidden
        
        public ImplicitGrantTypeFeature(ImplicitGrantTypeFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/GrantTypes", "ImplicitGrantType", "\tCheck all the alternatives scenarios in implicit grant-type (RFC : https://www.r" +
                    "fc-editor.org/rfc/rfc8707.html#name-access-token-request)", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="No access token is issued then resulting claims are returned in the ID Token")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "No access token is issued then resulting claims are returned in the ID Token")]
        public void NoAccessTokenIsIssuedThenResultingClaimsAreReturnedInTheIDToken()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("No access token is issued then resulting claims are returned in the ID Token", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table208 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table208.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table208.AddRow(new string[] {
                            "client_id",
                            "fourteenClient"});
                table208.AddRow(new string[] {
                            "state",
                            "state"});
                table208.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table208.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table208.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table208.AddRow(new string[] {
                            "nonce",
                            "nonce"});
#line 6
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table208, "When ");
#line hidden
#line 16
 testRunner.And("extract parameter \'id_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("extract payload from JWT \'$id_token$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.Then("redirection url doesn\'t contain the parameter \'access_token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.Then("JWT contains \'iss\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.Then("JWT contains \'iat\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Then("JWT contains \'exp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Then("JWT contains \'azp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.Then("JWT contains \'aud\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.Then("JWT has \'sub\'=\'user\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.Then("JWT has \'email\'=\'email@outlook.fr\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.Then("JWT has \'role\'=\'role1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.Then("JWT has \'role\'=\'role2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.Then("JWT has \'nonce\'=\'nonce\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Display parameter is passed in the redirection url")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "Display parameter is passed in the redirection url")]
        public void DisplayParameterIsPassedInTheRedirectionUrl()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display parameter is passed in the redirection url", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 31
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 32
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table209 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table209.AddRow(new string[] {
                            "response_type",
                            "id_token"});
                table209.AddRow(new string[] {
                            "client_id",
                            "fourteenClient"});
                table209.AddRow(new string[] {
                            "state",
                            "state"});
                table209.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table209.AddRow(new string[] {
                            "scope",
                            "openid email role"});
                table209.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table209.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table209.AddRow(new string[] {
                            "display",
                            "popup"});
#line 33
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table209, "When ");
#line hidden
#line 44
 testRunner.Then("redirection url contains the parameter value \'display\'=\'popup\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="scopes \'admin\' and \'calendar\' and valid audiences are returned in the access toke" +
            "n when resource parameter is specified with no scope")]
        [Xunit.TraitAttribute("FeatureTitle", "ImplicitGrantType")]
        [Xunit.TraitAttribute("Description", "scopes \'admin\' and \'calendar\' and valid audiences are returned in the access toke" +
            "n when resource parameter is specified with no scope")]
        public void ScopesAdminAndCalendarAndValidAudiencesAreReturnedInTheAccessTokenWhenResourceParameterIsSpecifiedWithNoScope()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scopes \'admin\' and \'calendar\' and valid audiences are returned in the access toke" +
                    "n when resource parameter is specified with no scope", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 46
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 47
 testRunner.Given("authenticate a user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table210 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table210.AddRow(new string[] {
                            "response_type",
                            "code token"});
                table210.AddRow(new string[] {
                            "client_id",
                            "fortySixClient"});
                table210.AddRow(new string[] {
                            "state",
                            "state"});
                table210.AddRow(new string[] {
                            "response_mode",
                            "query"});
                table210.AddRow(new string[] {
                            "redirect_uri",
                            "http://localhost:8080"});
                table210.AddRow(new string[] {
                            "nonce",
                            "nonce"});
                table210.AddRow(new string[] {
                            "claims",
                            "{ \"id_token\": { \"acr\": { \"essential\" : true, \"value\": \"urn:openbanking:psd2:ca\" }" +
                                " } }"});
                table210.AddRow(new string[] {
                            "resource",
                            "https://cal.example.com"});
                table210.AddRow(new string[] {
                            "resource",
                            "https://contacts.example.com"});
#line 49
 testRunner.When("execute HTTP GET request \'http://localhost/authorization\'", ((string)(null)), table210, "When ");
#line hidden
#line 61
 testRunner.And("extract parameter \'access_token\' from redirect url", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("extract payload from JWT \'$access_token$\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then("JWT has \'aud\'=\'https://cal.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Then("JWT has \'aud\'=\'https://contacts.example.com\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.Then("JWT has \'scope\'=\'admin\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.Then("JWT has \'scope\'=\'calendar\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ImplicitGrantTypeFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ImplicitGrantTypeFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
