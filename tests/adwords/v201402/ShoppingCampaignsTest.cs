﻿// Copyright 2014, Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Author: api.anash@gmail.com (Anash P. Oommen)

using Google.Api.Ads.AdWords.Lib;
using Google.Api.Ads.AdWords.v201402;

using NUnit.Framework;

using CSharpExamples = Google.Api.Ads.AdWords.Examples.CSharp.v201402;
using VBExamples = Google.Api.Ads.AdWords.Examples.VB.v201402;

namespace Google.Api.Ads.AdWords.Tests.v201402 {

  /// <summary>
  /// Test cases for all the code examples under v201402\ShoppingCampaigns.
  /// </summary>
  internal class ShoppingCampaignsTest : VersionedExampleTestsBase {
    private long adGroupId;
    private long budgetId;
    private long campaignId;

    /// <summary>
    /// Inits this instance.
    /// </summary>
    [SetUp]
    public void Init() {
      budgetId = utils.CreateBudget(user);
      campaignId = utils.CreateShoppingCampaign(user, BiddingStrategyType.MANUAL_CPC);
      adGroupId = utils.CreateAdGroup(user, campaignId);
    }

    /// <summary>
    /// Tests the AddProductPartitionTree C# code example.
    /// </summary>
    [Test]
    public void TestAddProductPartitionTreeCSharpExample() {
      RunExample(delegate() {
        new CSharpExamples.AddProductPartitionTree().Run(user, adGroupId);
      });
    }

    /// <summary>
    /// Tests the AddProductPartitionTree VB.NET code example.
    /// </summary>
    [Test]
    public void TestAddProductPartitionTreeVBExample() {
      RunExample(delegate() {
        new VBExamples.AddProductPartitionTree().Run(user, adGroupId);
      });
    }

    /// <summary>
    /// Tests the AddProductScope C# code example.
    /// </summary>
    [Test]
    public void TestAddProductScopeCSharpExample() {
      RunExample(delegate() {
        new CSharpExamples.AddProductScope().Run(user, campaignId);
      });
    }

    /// <summary>
    /// Tests the AddProductScope VB.NET code example.
    /// </summary>
    [Test]
    public void TestAddProductScopeVBExample() {
      RunExample(delegate() {
        new VBExamples.AddProductScope().Run(user, campaignId);
      });
    }

    /// <summary>
    /// Tests the GetAccountChanges C# code example.
    /// </summary>
    [Test]
    public void TestAddShoppingCampaignCSharpExample() {
      AdWordsAppConfig config = (AdWordsAppConfig) user.Config;
      RunExample(delegate() {
        new CSharpExamples.AddShoppingCampaign().Run(user, budgetId, config.MerchantCenterId);
      });
    }

    /// <summary>
    /// Tests the GetAccountChanges VB.NET code example.
    /// </summary>
    [Test]
    public void TestAddShoppingCampaignVBExample() {
      AdWordsAppConfig config = (AdWordsAppConfig) user.Config;
      RunExample(delegate() {
        new VBExamples.AddShoppingCampaign().Run(user, budgetId, config.MerchantCenterId);
      });
    }

    /// <summary>
    /// Tests the GetProductCategoryTaxonomy C# code example.
    /// </summary>
    [Test]
    public void TestGetProductCategoryTaxonomyCSharpExample() {
      RunExample(delegate() {
        new CSharpExamples.GetProductCategoryTaxonomy().Run(user);
      });
    }

    /// <summary>
    /// Tests the GetProductCategoryTaxonomy VB.NET code example.
    /// </summary>
    [Test]
    public void TestGetProductCategoryTaxonomyVBExample() {
      RunExample(delegate() {
        new VBExamples.GetProductCategoryTaxonomy().Run(user);
      });
    }

    /// <summary>
    /// Tests the SetProductSalesChannel C# code example.
    /// </summary>
    [Test]
    public void TestSetProductSalesChannelCSharpExample() {
      RunExample(delegate() {
        new CSharpExamples.SetProductSalesChannel().Run(user, campaignId);
      });
    }

    /// <summary>
    /// Tests the SetProductSalesChannel VB.NET code example.
    /// </summary>
    [Test]
    public void TestSetProductSalesChannelVBExample() {
      RunExample(delegate() {
        new VBExamples.SetProductSalesChannel().Run(user, campaignId);
      });
    }
  }
}
