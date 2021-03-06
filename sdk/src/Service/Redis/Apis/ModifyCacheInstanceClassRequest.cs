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
 * 缓存Redis实例接口
 * 缓存Redis实例相关接口
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

namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  变更缓存Redis实例配置，只能变更运行状态的实例配置，变更配置的规格不能与之前的相同
        ///         /// 预付费用户，从集群版变配到主从版，新规格的内存大小要大于老规格的内存大小，从主从版到集群版，新规格的内存大小要不小于老规格的内存大小
        ///         /// 
    /// </summary>
    public class ModifyCacheInstanceClassRequest : JdcloudRequest
    {
        ///<summary>
        /// 变更后的缓存Redis规格，详细参见：&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/411/isCatalog/1&quot;&gt;实例规格代码&lt;/a&gt;
        ///Required:true
        ///</summary>
        [Required]
        public   string CacheInstanceClass{ get; set; }
        ///<summary>
        /// 缓存Redis实例所在区域的Region ID。目前缓存Redis有华北、华南、华东区域，对应Region ID为cn-north-1、cn-south-1、cn-east-2
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 缓存Redis实例ID，是访问实例的唯一标识。
        ///Required:true
        ///</summary>
        [Required]
        public   string CacheInstanceId{ get; set; }
    }
}