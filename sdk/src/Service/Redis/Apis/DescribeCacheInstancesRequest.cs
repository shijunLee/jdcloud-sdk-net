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

using JDCloudSDK.Common.Model;
using JDCloudSDK.Core.Annotation;

namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    /// 查询缓存Redis实例列表
    /// </summary>
    public class DescribeCacheInstancesRequest : JdcloudRequest
    {
        ///<summary>
        ///页码；默认为1
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        ///分页大小；默认为20；取值范围[10, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        ///cacheInstanceId -实例Id，精确匹配，支持多个
        ///cacheInstanceName - 实例名称，模糊匹配，支持单个
        ///cacheInstanceStatus - redis状态，精确匹配，支持多个(running：运行，error：错误，creating：创建中，changing：变配中，deleting：删除中)
        ///
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        ///createTime - 创建时间(asc：正序，desc：倒序)
        ///
        ///</summary>
        public List<Sort> Sorts{ get; set; }

        ///<summary>
        ///缓存Redis实例所在区域的Region ID。目前缓存Redis有华北、华南、华东区域，对应Region ID为cn-north-1、cn-south-1、cn-east-2
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}