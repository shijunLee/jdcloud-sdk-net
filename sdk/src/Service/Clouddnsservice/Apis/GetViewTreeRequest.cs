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
 * 解析记录
 * 云解析OpenAPI解析记录接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Clouddnsservice.Apis
{

    /// <summary>
    ///  查询云解析所有的基础解析线路。  
        ///         /// 在使用解析线路的参数之前，请调用此接口获取解析线路的ID。
        ///         /// 
    /// </summary>
    public class GetViewTreeRequest : JdcloudRequest
    {
        ///<summary>
        /// 展示方式，暂时不使用
        ///</summary>
        public   int? LoadMode{ get; set; }
        ///<summary>
        /// 套餐ID，0-&gt;免费版 1-&gt;企业版 2-&gt;企业高级版
        ///Required:true
        ///</summary>
        [Required]
        public   int PackId{ get; set; }
        ///<summary>
        /// view ID，默认为-1
        ///Required:true
        ///</summary>
        [Required]
        public   int ViewId{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 域名ID，请使用getDomains接口获取。
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainId{ get; set; }
    }
}