// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management.Models
{
    /// <summary>
    /// Your documentation here.
    /// </summary>
    public partial class AdminOfferDefinition
    {
        private IList<AdminPlanDefinition> _addonPlans;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public IList<AdminPlanDefinition> AddonPlans
        {
            get { return this._addonPlans; }
            set { this._addonPlans = value; }
        }
        
        private IList<AdminPlanDefinition> _basePlans;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public IList<AdminPlanDefinition> BasePlans
        {
            get { return this._basePlans; }
            set { this._basePlans = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _displayName;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private string _externalReferenceId;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string ExternalReferenceId
        {
            get { return this._externalReferenceId; }
            set { this._externalReferenceId = value; }
        }
        
        private int? _maxSubscriptionsPerAccount;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public int? MaxSubscriptionsPerAccount
        {
            get { return this._maxSubscriptionsPerAccount; }
            set { this._maxSubscriptionsPerAccount = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private QuotaSyncState _quotaSyncState;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public QuotaSyncState QuotaSyncState
        {
            get { return this._quotaSyncState; }
            set { this._quotaSyncState = value; }
        }
        
        private AccessibilityState _state;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public AccessibilityState State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private int? _subscriptionCount;
        
        /// <summary>
        /// Optional. Your documentation here.
        /// </summary>
        public int? SubscriptionCount
        {
            get { return this._subscriptionCount; }
            set { this._subscriptionCount = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AdminOfferDefinition class.
        /// </summary>
        public AdminOfferDefinition()
        {
            this.AddonPlans = new LazyList<AdminPlanDefinition>();
            this.BasePlans = new LazyList<AdminPlanDefinition>();
        }
    }
}