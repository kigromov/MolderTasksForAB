﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.5.0.0
//      SpecFlow Generator Version:3.5.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AlfaBankTestTasks.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.5.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Labels")]
    [NUnit.Framework.CategoryAttribute("labels")]
    [NUnit.Framework.CategoryAttribute("core")]
    [NUnit.Framework.CategoryAttribute("epic:v1.2")]
    [NUnit.Framework.CategoryAttribute("owner:Vasya")]
    public partial class LabelsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "labels",
                "core",
                "epic:v1.2",
                "owner:Vasya"};
        
#line 1 "Labels.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Labels", null, ProgrammingLanguage.CSharp, new string[] {
                        "labels",
                        "core",
                        "epic:v1.2",
                        "owner:Vasya"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[v1.2 accounting] [ui.core] Selenium test 1")]
        [NUnit.Framework.CategoryAttribute("passed")]
        [NUnit.Framework.CategoryAttribute("ui")]
        [NUnit.Framework.CategoryAttribute("story:accounting")]
        [NUnit.Framework.CategoryAttribute("123")]
        [NUnit.Framework.CategoryAttribute("tms:234")]
        [NUnit.Framework.CategoryAttribute("package:com.company.accounting")]
        [NUnit.Framework.CategoryAttribute("class:main")]
        [NUnit.Framework.CategoryAttribute("method:getLedger")]
        [NUnit.Framework.CategoryAttribute("tag1")]
        public virtual void V1_2AccountingUi_CoreSeleniumTest1()
        {
            string[] tagsOfScenario = new string[] {
                    "passed",
                    "ui",
                    "story:accounting",
                    "123",
                    "tms:234",
                    "package:com.company.accounting",
                    "class:main",
                    "method:getLedger",
                    "tag1"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2 accounting] [ui.core] Selenium test 1", null, tagsOfScenario, argumentsOfScenario);
#line 5
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[v1.2] [api.core] Api test 1")]
        [NUnit.Framework.CategoryAttribute("passed")]
        [NUnit.Framework.CategoryAttribute("api")]
        [NUnit.Framework.CategoryAttribute("blocker")]
        [NUnit.Framework.CategoryAttribute("567")]
        [NUnit.Framework.CategoryAttribute("999999")]
        public virtual void V1_2Api_CoreApiTest1()
        {
            string[] tagsOfScenario = new string[] {
                    "passed",
                    "api",
                    "blocker",
                    "567",
                    "999999"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2] [api.core] Api test 1", null, tagsOfScenario, argumentsOfScenario);
#line 8
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[v1.2] [api.core.create] Api test 2")]
        [NUnit.Framework.CategoryAttribute("passed")]
        [NUnit.Framework.CategoryAttribute("api")]
        [NUnit.Framework.CategoryAttribute("create")]
        [NUnit.Framework.CategoryAttribute("link:http://example.org")]
        public virtual void V1_2Api_Core_CreateApiTest2()
        {
            string[] tagsOfScenario = new string[] {
                    "passed",
                    "api",
                    "create",
                    "link:http://example.org"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2] [api.core.create] Api test 2", null, tagsOfScenario, argumentsOfScenario);
#line 11
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[v1.2] [api.core.update] Api test 3")]
        [NUnit.Framework.CategoryAttribute("passed")]
        [NUnit.Framework.CategoryAttribute("api")]
        [NUnit.Framework.CategoryAttribute("update")]
        public virtual void V1_2Api_Core_UpdateApiTest3()
        {
            string[] tagsOfScenario = new string[] {
                    "passed",
                    "api",
                    "update"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2] [api.core.update] Api test 3", null, tagsOfScenario, argumentsOfScenario);
#line 14
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[v1.2 accounting] [core.update] Update test")]
        [NUnit.Framework.CategoryAttribute("passed")]
        [NUnit.Framework.CategoryAttribute("update")]
        [NUnit.Framework.CategoryAttribute("story:accounting")]
        public virtual void V1_2AccountingCore_UpdateUpdateTest()
        {
            string[] tagsOfScenario = new string[] {
                    "passed",
                    "update",
                    "story:accounting"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2 accounting] [core.update] Update test", null, tagsOfScenario, argumentsOfScenario);
#line 17
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[v1.2 / v.2.0 security] [core.update] [com.company.security.main.getACL] Get ACL " +
            "test")]
        [NUnit.Framework.CategoryAttribute("passed")]
        [NUnit.Framework.CategoryAttribute("epic:v.2.0")]
        [NUnit.Framework.CategoryAttribute("story:security")]
        [NUnit.Framework.CategoryAttribute("package:com.company.security")]
        [NUnit.Framework.CategoryAttribute("class:main")]
        [NUnit.Framework.CategoryAttribute("method:getACL")]
        public virtual void V1_2V_2_0SecurityCore_UpdateCom_Company_Security_Main_GetACLGetACLTest()
        {
            string[] tagsOfScenario = new string[] {
                    "passed",
                    "epic:v.2.0",
                    "story:security",
                    "package:com.company.security",
                    "class:main",
                    "method:getACL"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[v1.2 / v.2.0 security] [core.update] [com.company.security.main.getACL] Get ACL " +
                    "test", null, tagsOfScenario, argumentsOfScenario);
#line 20
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
