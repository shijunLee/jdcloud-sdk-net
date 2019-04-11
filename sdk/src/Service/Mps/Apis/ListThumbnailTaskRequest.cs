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
 * 媒体处理相关接口
 * 多媒体处理服务API，包括截图、转码、媒体处理消息通知等操作。本文档详细说明了媒体处理API及用法，适合开发人员阅读。
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

namespace  JDCloudSDK.Mps.Apis
{

    /// <summary>
    ///  查询截图任务，返回满足查询条件的任务列表。
    /// </summary>
    public class ListThumbnailTaskRequest : JdcloudRequest
    {
        ///<summary>
        /// task 状态 (PENDING, RUNNING, SUCCESS, FAILED)
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 开始时间 时间格式(GMT): yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;
        ///</summary>
        public   string Begin{ get; set; }
        ///<summary>
        /// 结束时间 时间格式(GMT): yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS&#39;Z&#39;
        ///</summary>
        public   string End{ get; set; }
        ///<summary>
        /// 查询标记
        ///</summary>
        public   string Marker{ get; set; }
        ///<summary>
        /// 查询记录数 [1, 1000]
        ///</summary>
        public   int? Limit{ get; set; }
        ///<summary>
        /// region id
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}