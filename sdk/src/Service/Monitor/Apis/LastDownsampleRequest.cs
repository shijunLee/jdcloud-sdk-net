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
 * Monitoring Items APIs
 * 监控项相关接口，提供可用监控项列表查询和监控数据查询等功能
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
using JDCloudSDK.Monitor.Model;

namespace  JDCloudSDK.Monitor.Apis
{

    /// <summary>
    ///  查看某资源的最后一个点,metric介绍：&lt;a href&#x3D;&quot;https://docs.jdcloud.com/cn/monitoring/metrics&quot;&gt;Metrics&lt;/a&gt;
    /// </summary>
    public class LastDownsampleRequest : JdcloudRequest
    {
        ///<summary>
        /// 资源的类型，取值vm, lb, ip, database 等
        ///Required:true
        ///</summary>
        [Required]
        public   string ServiceCode{ get; set; }
        ///<summary>
        /// 资源的uuid，支持多个resourceId批量查询，每个id用竖线分隔。 如：id1|id2|id3|id4
        ///Required:true
        ///</summary>
        [Required]
        public   string ResourceId{ get; set; }
        ///<summary>
        /// 自定义标签
        ///</summary>
        public List<TagFilter> Tags{ get; set; }

        ///<summary>
        /// 查询时间范围的开始时间， UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ssZ（默认为当前时间，早于30d时，将被重置为30d）
        ///</summary>
        public   string StartTime{ get; set; }
        ///<summary>
        /// 查询时间范围的结束时间， UTC时间，格式：2016-12- yyyy-MM-dd&#39;T&#39;HH:mm:ssZ（为空时，将由startTime与timeInterval计算得出）
        ///</summary>
        public   string EndTime{ get; set; }
        ///<summary>
        /// 查询的时间间隔，最大不超过30天，支持分钟级别,小时级别，天级别，例如：1m、1h、1d
        ///</summary>
        public   string TimeInterval{ get; set; }
        ///<summary>
        /// 聚合方式：max avg min等,用于不同维度之间聚合
        ///</summary>
        public   string AggrType{ get; set; }
        ///<summary>
        /// 聚合方式：max avg min等,用于将维度内一个周期数据聚合为一个点的聚合方式
        ///</summary>
        public   string DownAggrType{ get; set; }
        ///<summary>
        /// 地域 Id
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 监控项英文标识(id)
        ///Required:true
        ///</summary>
        [Required]
        public   string Metric{ get; set; }
    }
}