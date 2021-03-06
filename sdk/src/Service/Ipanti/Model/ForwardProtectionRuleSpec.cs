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
    ///  forwardProtectionRuleSpec
    /// </summary>
    public class ForwardProtectionRuleSpec
    {

        ///<summary>
        /// 虚假源与空连接, 0: 关闭, 1: 开启
        ///Required:true
        ///</summary>
        [Required]
        public int SpoofIpEnable{ get; set; }
        ///<summary>
        /// 源新建连接限速, 0: 关闭, 1: 开启
        ///Required:true
        ///</summary>
        [Required]
        public int SrcNewConnLimitEnable{ get; set; }
        ///<summary>
        /// 源新建连接速率
        ///Required:true
        ///</summary>
        [Required]
        public long SrcNewConnLimitValue{ get; set; }
        ///<summary>
        /// 源并发连接限速, 0: 关闭, 1: 开启
        ///Required:true
        ///</summary>
        [Required]
        public int SrcConcurrentConnLimitEnable{ get; set; }
        ///<summary>
        /// 源并发连接速率
        ///Required:true
        ///</summary>
        [Required]
        public long SrcConcurrentConnLimitValue{ get; set; }
        ///<summary>
        /// 目的新建连接, 0: 关闭, 1: 开启
        ///Required:true
        ///</summary>
        [Required]
        public int DstNewConnLimitEnable{ get; set; }
        ///<summary>
        /// 目的新建连接速率
        ///Required:true
        ///</summary>
        [Required]
        public long DstNewConnLimitValue{ get; set; }
        ///<summary>
        /// 目的并发连接, 0: 关闭, 1: 开启
        ///Required:true
        ///</summary>
        [Required]
        public int DstConcurrentConnLimitEnable{ get; set; }
        ///<summary>
        /// 目的并发连接速率
        ///Required:true
        ///</summary>
        [Required]
        public long DstConcurrentConnLimitValue{ get; set; }
        ///<summary>
        /// 报文最小长度, 取值范围[0, datagramRangeMax)
        ///Required:true
        ///</summary>
        [Required]
        public long DatagramRangeMin{ get; set; }
        ///<summary>
        /// 报文最大长度, 取值范围(datagramRangeMin, 1518]
        ///Required:true
        ///</summary>
        [Required]
        public long DatagramRangeMax{ get; set; }
        ///<summary>
        /// geo 拦截地域编码列表, 可设置编码列表由 describeGeoAreas 接口查询可得
        ///</summary>
        public List<string> GeoBlackList{ get; set; }
    }
}
