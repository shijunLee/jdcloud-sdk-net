/*
 * Copyright 2018 JDCLOUD.COM
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http:#www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  protectionOutline
    /// </summary>
    public class ProtectionOutline
    {

        ///<summary>
        /// 实例数量
        ///</summary>
        public int? InstancesCount{ get; set; }
        ///<summary>
        /// 已防护实例数量
        ///</summary>
        public int? ProtectedCount{ get; set; }
        ///<summary>
        /// 已防护天数
        ///</summary>
        public int? ProtectedDay{ get; set; }
        ///<summary>
        /// 7 日攻击次数
        ///</summary>
        public int? WeekAttackCount{ get; set; }
        ///<summary>
        /// 7 日攻击流量峰值
        ///</summary>
        public double? WeekAttackPeak{ get; set; }
        ///<summary>
        /// 7 日攻击流量单位
        ///</summary>
        public string WeekAttackUnit{ get; set; }
        ///<summary>
        /// 30 日攻击次数
        ///</summary>
        public int? MonthAttackCount{ get; set; }
        ///<summary>
        /// 30 日攻击流量峰值
        ///</summary>
        public double? MonthAttackPeak{ get; set; }
        ///<summary>
        /// 30 日攻击流量单位
        ///</summary>
        public string MonthAttackUnit{ get; set; }
    }
}