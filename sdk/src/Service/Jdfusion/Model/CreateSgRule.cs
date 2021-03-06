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

namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  创建安全组规则
    /// </summary>
    public class CreateSgRule
    {

        ///<summary>
        /// 规则类型，ingress、egress
        ///Required:true
        ///</summary>
        [Required]
        public string RuleType{ get; set; }
        ///<summary>
        /// 协议，tcp、udp、icmp 或者 all
        ///Required:true
        ///</summary>
        [Required]
        public string Protocol{ get; set; }
        ///<summary>
        /// 起始端口
        ///Required:true
        ///</summary>
        [Required]
        public int FromPort{ get; set; }
        ///<summary>
        /// 终止端口
        ///Required:true
        ///</summary>
        [Required]
        public int ToPort{ get; set; }
        ///<summary>
        /// 安全组ID
        ///Required:true
        ///</summary>
        [Required]
        public string SecurityGroupId{ get; set; }
        ///<summary>
        /// 网络类型，internet、intranet
        ///</summary>
        public string NicType{ get; set; }
        ///<summary>
        /// 认证策略，accept、drop
        ///</summary>
        public string Policy{ get; set; }
        ///<summary>
        /// 认证策略的权重，1-100。
        ///</summary>
        public int? Priority{ get; set; }
        ///<summary>
        /// 目标IP地址范围
        ///Required:true
        ///</summary>
        [Required]
        public string CidrIp{ get; set; }
    }
}
