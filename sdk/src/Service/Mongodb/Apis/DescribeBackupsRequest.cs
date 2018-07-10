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
 * backup相关接口
 * API related to Relational MONGODB Service
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

namespace  JDCloudSDK.Mongodb.Apis
{

    /// <summary>
    /// 查看备份
    /// </summary>
    public class DescribeBackupsRequest : JdcloudRequest
    {
        ///<summary>
        ///页码；默认为1，取值范围：[1,∞)
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        ///分页大小；默认为10；取值范围[1, 100]
        ///</summary>
        public   int? PageSize{ get; set; }
        ///<summary>
        ///instanceId - 实例ID, 精确匹配
        ///backupId - 备份ID, 精确匹配
        ///
        ///</summary>
        public List<Filter> Filters{ get; set; }

        ///<summary>
        ///Region ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}