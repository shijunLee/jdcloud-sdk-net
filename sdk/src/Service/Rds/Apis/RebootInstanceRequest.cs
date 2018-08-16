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
 * 实例管理
 * 实例管理相关接口
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

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  重启RDS实例&lt;/br&gt;- SQL Server：支持&lt;/br&gt;- MySQL：支持
    /// </summary>
    public class RebootInstanceRequest : JdcloudRequest
    {
        ///<summary>
        /// 是否重启主节点。&lt;/br&gt;- SQL Server：支持&lt;/br&gt;- MySQL：暂不支持
        ///</summary>
        public   bool RebootMaster{ get; set; }
        ///<summary>
        /// 是否重启从节点。&lt;/br&gt;- SQL Server：支持&lt;/br&gt;- MySQL：暂不支持
        ///</summary>
        public   bool RebootSlave{ get; set; }
        ///<summary>
        /// Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// Instance ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}