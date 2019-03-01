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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  priceSpec
    /// </summary>
    public class PriceSpec
    {

        ///<summary>
        /// 操作类型 1: 新购高防实例, 3: 升级高防实例
        ///Required:true
        ///</summary>
        [Required]
        public int BuyType{ get; set; }
        ///<summary>
        /// 计费类型 1: 按配置 2: 按用量 3: 包年包月
        ///Required:true
        ///</summary>
        [Required]
        public int BillingType{ get; set; }
        ///<summary>
        /// 链路类型, 1: 电信, 2: 电信、联通, 3: 电信、联通和移动
        ///Required:true
        ///</summary>
        [Required]
        public int Carrier{ get; set; }
        ///<summary>
        /// 业务带宽: 100, 150, 200, 250, ..., 2000, 单位: M
        ///Required:true
        ///</summary>
        [Required]
        public int Bw{ get; set; }
        ///<summary>
        /// 保底带宽: 0, 10, 20, 30, 40, 50, 60, 80, 100, 单位: Gbps
        ///Required:true
        ///</summary>
        [Required]
        public int Bp{ get; set; }
        ///<summary>
        /// 弹性带宽: 0, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 120, 150, 200, 单位: Gbps
        ///Required:true
        ///</summary>
        [Required]
        public int Ep{ get; set; }
        ///<summary>
        /// 实例 Id, 升级高防实例查询价格时必传
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// 购买防护包时长, 新购高防实例时必传
        /// - timeUnit 为 3 时, 可取值 1-9
        /// - timeUnit 为 4 时, 可取值 1-3
        /// 
        ///</summary>
        public int? TimeSpan{ get; set; }
        ///<summary>
        /// 购买时长类型, 新购高防实例时必传
        /// - 3: 月
        /// - 4: 年
        ///</summary>
        public int? TimeUnit{ get; set; }
    }
}
