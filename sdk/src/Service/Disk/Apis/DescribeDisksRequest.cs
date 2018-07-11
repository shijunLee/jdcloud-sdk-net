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
 * 云硬盘相关接口
 * 云硬盘相关接口，提供批量创建云硬盘，查询云硬盘，删除云硬盘，对云硬盘进行扩容，修改云硬盘信息以及使用快照恢复云硬盘等功能。
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

using JDCloudSDK.Disk.Model;
using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Disk.Apis
{

    /// <summary>
    /// 查询云硬盘列表
    /// </summary>
    public class DescribeDisksRequest : JdcloudRequest
    {
        ///<summary>
        ///页码, 默认为1, 取值范围：[1,∞)
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        ///分页大小，默认为20，取值范围：[10,100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        ///Tag筛选条件
        ///</summary>
        public List<TagFilter> Tags{ get; set; }

        ///<summary>
        ///diskId - 云硬盘ID，精确匹配，支持多个
        ///diskType - 云硬盘类型，精确匹配，支持多个，取值为 ssd 或 premium-hdd
        ///instanceId - 云硬盘所挂载主机的ID，精确匹配，支持多个
        ///instanceType - 云硬盘所挂载主机的类型，精确匹配，支持多个
        ///status - 可用区，精确匹配，支持多个
        ///az - 云硬盘状态，精确匹配，支持多个
        ///name - 云硬盘名称，模糊匹配，支持单个
        ///
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        ///地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}