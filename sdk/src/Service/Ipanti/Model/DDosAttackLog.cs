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
    ///  dDosAttackLog
    /// </summary>
    public class DDosAttackLog
    {

        ///<summary>
        /// 攻击流量大小
        ///</summary>
        public float? AttackTraffic{ get; set; }
        ///<summary>
        /// 是否触发黑洞，0否 1是
        ///</summary>
        public int? BlackHole{ get; set; }
        ///<summary>
        /// 攻击开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 攻击结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 流量单位，bps、Kbps、Mbps、Gbps
        ///</summary>
        public string Unit{ get; set; }
        ///<summary>
        /// 高防实例id
        ///</summary>
        public long? InstanceId{ get; set; }
        ///<summary>
        /// 高防实例名称
        ///</summary>
        public string Name{ get; set; }
    }
}