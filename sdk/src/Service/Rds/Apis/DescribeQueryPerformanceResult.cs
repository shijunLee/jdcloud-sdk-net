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
 * 性能统计
 * 性能统计相关接口
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

using JDCloudSDK.Rds.Model;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    ///  根据用户定义的查询条件，获取SQL执行的性能统计信息，例如慢SQL等。用户可以根据这些信息查找与SQL执行相关的性能瓶颈，并进行优化。&lt;br&gt;- 仅支持SQL Server
    /// </summary>
    public class DescribeQueryPerformanceResult : JdcloudResult
    {
        ///<summary>
        /// QueryPerformanceResult
        ///</summary>
        public List<QueryPerformanceResult> QueryPerformanceResult{ get; set; }

        ///<summary>
        /// 总记录条数
        ///</summary>
        public   int? TotalCount{ get; set; }
        ///<summary>
        /// 当前数据的页码
        ///</summary>
        public   int? PageNumber{ get; set; }
        ///<summary>
        /// 每页显示的数据条数
        ///</summary>
        public   int? PageSize{ get; set; }
    }
}