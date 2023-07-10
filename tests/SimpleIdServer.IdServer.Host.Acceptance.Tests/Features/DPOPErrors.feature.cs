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
namespace SimpleIdServer.IdServer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DPOPErrorsFeature : object, Xunit.IClassFixture<DPOPErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DPOPErrors.feature"
#line hidden
        
        public DPOPErrorsFeature(DPOPErrorsFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "DPOPErrors", "\tCheck errors returned when validating the DPOP Proof", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="at least one DPoP header must be passed")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "at least one DPoP header must be passed")]
        public void AtLeastOneDPoPHeaderMustBePassed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("at least one DPoP header must be passed", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table188 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table188.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table188.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table188.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table188.AddRow(new string[] {
                            "client_secret",
                            "password"});
#line 5
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table188, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("JSON \'$.error_description\'=\'the DPOP Proof is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="only one DPoP header must be passed")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "only one DPoP header must be passed")]
        public void OnlyOneDPoPHeaderMustBePassed()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("only one DPoP header must be passed", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table189 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table189.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table189.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table189.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table189.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table189.AddRow(new string[] {
                            "DPoP",
                            "value1"});
                table189.AddRow(new string[] {
                            "DPoP",
                            "value2"});
#line 18
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table189, "When ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.And("JSON \'$.error\'=\'invalid_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("JSON \'$.error_description\'=\'too many DPoP parameters are passed in the header\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="DPoP header is not a JWT")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "DPoP header is not a JWT")]
        public void DPoPHeaderIsNotAJWT()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DPoP header is not a JWT", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table190 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table190.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table190.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table190.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table190.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table190.AddRow(new string[] {
                            "DPoP",
                            "value1"});
#line 33
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table190, "When ");
#line hidden
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("JSON \'$.error_description\'=\'DPoP Proof must be a Json Web Token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="htm parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "htm parameter is required")]
        public void HtmParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("htm parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table191 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
#line 47
 testRunner.Given("build DPoP proof", ((string)(null)), table191, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table192 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table192.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table192.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table192.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table192.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table192.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 50
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table192, "When ");
#line hidden
#line 58
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("JSON \'$.error_description\'=\'the parameter htm is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="htu parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "htu parameter is required")]
        public void HtuParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("htu parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table193 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table193.AddRow(new string[] {
                            "htm",
                            "htm"});
#line 64
 testRunner.Given("build DPoP proof", ((string)(null)), table193, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table194 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table194.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table194.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table194.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table194.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table194.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 68
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table194, "When ");
#line hidden
#line 76
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("JSON \'$.error_description\'=\'the parameter htu is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="htm parameter must match the HTTP method of the current request")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "htm parameter must match the HTTP method of the current request")]
        public void HtmParameterMustMatchTheHTTPMethodOfTheCurrentRequest()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("htm parameter must match the HTTP method of the current request", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 81
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table195 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table195.AddRow(new string[] {
                            "htm",
                            "GET"});
                table195.AddRow(new string[] {
                            "htu",
                            "htu"});
#line 82
 testRunner.Given("build DPoP proof", ((string)(null)), table195, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table196 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table196.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table196.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table196.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table196.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table196.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 87
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table196, "When ");
#line hidden
#line 95
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("JSON \'$.error_description\'=\'the htm parameter must be equals to POST\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="htu parameter must match the HTTP URI value for the HTTP request in which the JWT" +
            " was received")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "htu parameter must match the HTTP URI value for the HTTP request in which the JWT" +
            " was received")]
        public void HtuParameterMustMatchTheHTTPURIValueForTheHTTPRequestInWhichTheJWTWasReceived()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("htu parameter must match the HTTP URI value for the HTTP request in which the JWT" +
                    " was received", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 100
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table197 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table197.AddRow(new string[] {
                            "htm",
                            "POST"});
                table197.AddRow(new string[] {
                            "htu",
                            "htu"});
#line 101
 testRunner.Given("build DPoP proof", ((string)(null)), table197, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table198 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table198.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table198.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table198.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table198.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table198.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 106
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table198, "When ");
#line hidden
#line 114
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And("JSON \'$.error_description\'=\'the htu parameter must be equals to https://localhost" +
                        ":8080/token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="DPoP proof cannot have a lifetime superior to the limit")]
        [Xunit.TraitAttribute("FeatureTitle", "DPOPErrors")]
        [Xunit.TraitAttribute("Description", "DPoP proof cannot have a lifetime superior to the limit")]
        public void DPoPProofCannotHaveALifetimeSuperiorToTheLimit()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DPoP proof cannot have a lifetime superior to the limit", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 119
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table199 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table199.AddRow(new string[] {
                            "htm",
                            "POST"});
                table199.AddRow(new string[] {
                            "htu",
                            "https://localhost:8080/token"});
#line 120
 testRunner.Given("build DPoP proof with big lifetime", ((string)(null)), table199, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table200 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table200.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
                table200.AddRow(new string[] {
                            "scope",
                            "firstScope"});
                table200.AddRow(new string[] {
                            "client_id",
                            "sixtyThreeClient"});
                table200.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table200.AddRow(new string[] {
                            "DPoP",
                            "$DPOP$"});
#line 125
 testRunner.When("execute HTTP POST request \'https://localhost:8080/token\'", ((string)(null)), table200, "When ");
#line hidden
#line 133
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 135
 testRunner.And("JSON \'$.error\'=\'invalid_dpop_proof\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 136
 testRunner.And("JSON \'$.error_description\'=\'the DPoP cannot have a validity superior to 300 secon" +
                        "ds\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                DPOPErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DPOPErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
