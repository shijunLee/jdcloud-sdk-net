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
 * 快照相关接口
 * 快照相关接口，提供创建快照，查询快照信息，删除快照，修改快照信息等功能。
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

namespace  JDCloudSDK.Disk.Apis
{

    /// <summary>
    ///  修改快照的名字或描述信息
    /// </summary>
    public class ModifySnpAttributeRequest : JdcloudRequest
    {
        ///<summary>
        /// 快照名称
        ///</summary>
        public   string Name{ get; set; }
        ///<summary>
        /// 快照描述，name和description必须要指定一个
        ///</summary>
        public   string Description{ get; set; }
        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 快照ID
        ///Required:true
        ///</summary>
        [Required]
        public   string SnapshotId{ get; set; }
    }
}