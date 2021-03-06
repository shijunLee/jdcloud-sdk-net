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
using JDCloudSDK.Mps.Model;

namespace  JDCloudSDK.Mps.Apis
{

    /// <summary>
    ///  创建截图任务，创建成功时返回任务ID。本接口用于截取指定时间点的画面。
    /// </summary>
    public class CreateThumbnailTaskRequest : JdcloudRequest
    {
        ///<summary>
        /// 任务ID (readonly)
        ///</summary>
        public   string TaskID{ get; set; }
        ///<summary>
        /// 状态 (SUCCESS, ERROR, PENDDING, RUNNING) (readonly)
        ///</summary>
        public   string Status{ get; set; }
        ///<summary>
        /// 错误码 (readonly)
        ///</summary>
        public   int? ErrorCode{ get; set; }
        ///<summary>
        /// 任务创建时间 时间格式(GMT): yyyy-MM-dd’T’HH:mm:ss.SSS’Z’  (readonly)
        ///</summary>
        public   string CreatedTime{ get; set; }
        ///<summary>
        /// 任务创建时间 时间格式(GMT): yyyy-MM-dd’T’HH:mm:ss.SSS’Z’  (readonly)
        ///</summary>
        public   string LastUpdatedTime{ get; set; }
        ///<summary>
        /// Source
        ///Required:true
        ///</summary>
        [Required]
        public   ThumbnailTaskSource Source{ get; set; }
        ///<summary>
        /// Target
        ///Required:true
        ///</summary>
        [Required]
        public   ThumbnailTaskTarget Target{ get; set; }
        ///<summary>
        /// Rule
        ///</summary>
        public   ThumbnailTaskRule Rule{ get; set; }
        ///<summary>
        /// region id
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}