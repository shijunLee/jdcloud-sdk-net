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
 * 域名
 * 云解析OpenAPI域名接口
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
    ///  修改主域名
    /// </summary>
    public class UpdateDomainRequest : JdcloudRequest
    {
        ///<summary>
        /// 需要修改的主域名，请使用getDomains接口获取
        ///Required:true
        ///</summary>
        [Required]
        public   string DomainName{ get; set; }
        ///<summary>
        /// 需要修改的主域名ID，请使用getDomains接口获取
        ///Required:true
        ///</summary>
        [Required]
        public   int Id{ get; set; }
        ///<summary>
        /// 实例所属的地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}