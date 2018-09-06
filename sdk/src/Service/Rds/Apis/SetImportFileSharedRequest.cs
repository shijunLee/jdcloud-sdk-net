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
 * 单库上云
 * 单库上云相关接口
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
    ///  设置或取消上传文件是否共享给同一账号下的其他实例。缺省情况下，文件仅在上传的实例上可见并可导入，其他实例不可见不可导入。如果需要该文件在其他实例上也可导入，可将此文件设置为共享&lt;br&gt;- 仅支持SQL Server
    /// </summary>
    public class SetImportFileSharedRequest : JdcloudRequest
    {
        ///<summary>
        /// 文件是否共享&lt;br&gt;true:共享&lt;br&gt;false:不共享
        ///Required:true
        ///</summary>
        [Required]
        public   string Shared{ get; set; }
        ///<summary>
        /// 地域代码，取值范围参见[《各地域及可用区对照表》](../Enum-Definitions/Regions-AZ.md)
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// RDS 实例ID，唯一标识一个RDS实例
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        /// 单库上云文件名
        ///Required:true
        ///</summary>
        [Required]
        public   string FileName{ get; set; }
    }
}