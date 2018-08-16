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
 * 集群管理
 * JMR集群管理相关接口
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

namespace  JDCloudSDK.Jmr.Apis
{

    /// <summary>
    ///  集群扩容
    /// </summary>
    public class ClusterExpansionRequest : JdcloudRequest
    {
        ///<summary>
        /// 需要扩容的集群ID
        ///</summary>
        public   string ClusterId{ get; set; }
        ///<summary>
        /// 扩容的数量
        ///</summary>
        public   int? ExpansionNum{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}