/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Describes the strategy for using unused Capacity Reservations for fulfilling On-Demand
    /// capacity.
    /// </summary>
    public partial class OnDemandCapacityReservationOptions
    {
        private OnDemandCapacityReservationPreference _capacityReservationPreference;
        private OnDemandCapacityReservationUsageStrategy _usageStrategy;

        /// <summary>
        /// Gets and sets the property CapacityReservationPreference. 
        /// <para>
        /// Indicates the instance's Capacity Reservation preferences. Possible preferences include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>open</code> - The instance can run in any open Capacity Reservation that has
        /// matching attributes (instance type, platform, Availability Zone).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>none</code> - The instance avoids running in a Capacity Reservation even if
        /// one is available. The instance runs as an On-Demand Instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OnDemandCapacityReservationPreference CapacityReservationPreference
        {
            get { return this._capacityReservationPreference; }
            set { this._capacityReservationPreference = value; }
        }

        // Check to see if CapacityReservationPreference property is set
        internal bool IsSetCapacityReservationPreference()
        {
            return this._capacityReservationPreference != null;
        }

        /// <summary>
        /// Gets and sets the property UsageStrategy. 
        /// <para>
        /// Indicates whether to use unused Capacity Reservations for fulfilling On-Demand capacity.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>use-capacity-reservations-first</code>, the fleet uses unused
        /// Capacity Reservations to fulfill On-Demand capacity up to the target On-Demand capacity.
        /// If multiple instance pools have unused Capacity Reservations, the On-Demand allocation
        /// strategy (<code>lowest-price</code>) is applied. If the number of unused Capacity
        /// Reservations is less than the On-Demand target capacity, the remaining On-Demand target
        /// capacity is launched according to the On-Demand allocation strategy (<code>lowest-price</code>).
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the fleet fulfils the On-Demand capacity according
        /// to the chosen On-Demand allocation strategy.
        /// </para>
        /// </summary>
        public OnDemandCapacityReservationUsageStrategy UsageStrategy
        {
            get { return this._usageStrategy; }
            set { this._usageStrategy = value; }
        }

        // Check to see if UsageStrategy property is set
        internal bool IsSetUsageStrategy()
        {
            return this._usageStrategy != null;
        }

    }
}