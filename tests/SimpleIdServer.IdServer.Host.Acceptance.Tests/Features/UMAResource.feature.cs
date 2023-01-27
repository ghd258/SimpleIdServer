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
    public partial class UMAResourceFeature : object, Xunit.IClassFixture<UMAResourceFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UMAResource.feature"
#line hidden
        
        public UMAResourceFeature(UMAResourceFeature.FixtureData fixtureData, SimpleIdServer_IdServer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UMAResource", "\tCheck the endpoint /rreguri\t", ProgrammingLanguage.CSharp, featureTags);
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
        
        [Xunit.SkippableFactAttribute(DisplayName="add UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "add UMA resource")]
        public void AddUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("add UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                TechTalk.SpecFlow.Table table337 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table337.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table337.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table337.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table337.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 5
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table337, "When ");
#line hidden
#line 12
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table338 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table338.AddRow(new string[] {
                            "resource_scopes",
                            "[scope1,scope2]"});
                table338.AddRow(new string[] {
                            "subject",
                            "user1"});
                table338.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table338.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table338.AddRow(new string[] {
                            "name#en",
                            "name"});
                table338.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table338.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table338.AddRow(new string[] {
                            "type",
                            "type"});
                table338.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 15
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table338, "And ");
#line hidden
#line 27
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then("HTTP status code equals to \'201\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.And("JSON exists \'_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("JSON exists \'user_access_policy_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="get UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "get UMA resource")]
        public void GetUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("get UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table339 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table339.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table339.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table339.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table339.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 34
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table339, "When ");
#line hidden
#line 41
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table340 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table340.AddRow(new string[] {
                            "resource_scopes",
                            "[scope1,scope2]"});
                table340.AddRow(new string[] {
                            "subject",
                            "user1"});
                table340.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table340.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table340.AddRow(new string[] {
                            "name#en",
                            "name"});
                table340.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table340.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table340.AddRow(new string[] {
                            "type",
                            "type"});
                table340.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 44
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table340, "And ");
#line hidden
#line 56
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table341 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table341.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 59
 testRunner.And("execute HTTP GET request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table341, "And ");
#line hidden
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 66
 testRunner.And("JSON exists \'resource_scopes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("JSON \'icon_uri\'=\'icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("JSON \'name#fr\'=\'nom\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("JSON \'name#en\'=\'name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("JSON \'description#fr\'=\'descriptionFR\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("JSON \'description#en\'=\'descriptionEN\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("JSON \'type\'=\'type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="delete UMA resource")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "delete UMA resource")]
        public void DeleteUMAResource()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete UMA resource", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 74
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table342 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table342.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table342.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table342.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table342.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 75
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table342, "When ");
#line hidden
#line 82
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table343 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table343.AddRow(new string[] {
                            "resource_scopes",
                            "[scope1,scope2]"});
                table343.AddRow(new string[] {
                            "subject",
                            "user1"});
                table343.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table343.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table343.AddRow(new string[] {
                            "name#en",
                            "name"});
                table343.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table343.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table343.AddRow(new string[] {
                            "type",
                            "type"});
                table343.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 85
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table343, "And ");
#line hidden
#line 97
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table344 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table344.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 100
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table344, "And ");
#line hidden
#line 104
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="add UMA permissions")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "add UMA permissions")]
        public void AddUMAPermissions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("add UMA permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 106
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table345 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table345.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table345.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table345.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table345.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 107
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table345, "When ");
#line hidden
#line 114
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table346 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table346.AddRow(new string[] {
                            "resource_scopes",
                            "[scope1,scope2]"});
                table346.AddRow(new string[] {
                            "subject",
                            "user1"});
                table346.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table346.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table346.AddRow(new string[] {
                            "name#en",
                            "name"});
                table346.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table346.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table346.AddRow(new string[] {
                            "type",
                            "type"});
                table346.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 117
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table346, "And ");
#line hidden
#line 129
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table347 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table347.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table347.AddRow(new string[] {
                            "permissions",
                            "[ { \"claims\": [ { \"name\": \"sub\", \"value\": \"user\" } ], \"scopes\": [ \"scope\" ] } ]"});
#line 132
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/rreguri/$_id$/permissions\'", ((string)(null)), table347, "And ");
#line hidden
#line 137
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
 testRunner.Then("HTTP status code equals to \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.And("JSON exists \'_id\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="delete UMA permissions")]
        [Xunit.TraitAttribute("FeatureTitle", "UMAResource")]
        [Xunit.TraitAttribute("Description", "delete UMA permissions")]
        public void DeleteUMAPermissions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("delete UMA permissions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 142
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table348 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table348.AddRow(new string[] {
                            "client_id",
                            "fiftyThreeClient"});
                table348.AddRow(new string[] {
                            "client_secret",
                            "password"});
                table348.AddRow(new string[] {
                            "scope",
                            "uma_protection"});
                table348.AddRow(new string[] {
                            "grant_type",
                            "client_credentials"});
#line 143
 testRunner.When("execute HTTP POST request \'http://localhost/token\'", ((string)(null)), table348, "When ");
#line hidden
#line 150
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.And("extract parameter \'access_token\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table349 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table349.AddRow(new string[] {
                            "resource_scopes",
                            "[scope1,scope2]"});
                table349.AddRow(new string[] {
                            "subject",
                            "user1"});
                table349.AddRow(new string[] {
                            "icon_uri",
                            "icon"});
                table349.AddRow(new string[] {
                            "name#fr",
                            "nom"});
                table349.AddRow(new string[] {
                            "name#en",
                            "name"});
                table349.AddRow(new string[] {
                            "description#fr",
                            "descriptionFR"});
                table349.AddRow(new string[] {
                            "description#en",
                            "descriptionEN"});
                table349.AddRow(new string[] {
                            "type",
                            "type"});
                table349.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 153
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri\'", ((string)(null)), table349, "And ");
#line hidden
#line 165
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 166
 testRunner.And("extract parameter \'_id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table350 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table350.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
                table350.AddRow(new string[] {
                            "permissions",
                            "[ { \"claims\": [ { \"name\": \"sub\", \"value\": \"user\" } ], \"scopes\": [ \"scope\" ] } ]"});
#line 168
 testRunner.And("execute HTTP POST JSON request \'http://localhost/rreguri/$_id$/permissions\'", ((string)(null)), table350, "And ");
#line hidden
                TechTalk.SpecFlow.Table table351 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table351.AddRow(new string[] {
                            "Authorization",
                            "Bearer $access_token$"});
#line 173
 testRunner.And("execute HTTP DELETE request \'http://localhost/rreguri/$_id$\'", ((string)(null)), table351, "And ");
#line hidden
#line 177
 testRunner.Then("HTTP status code equals to \'204\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
                UMAResourceFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UMAResourceFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
