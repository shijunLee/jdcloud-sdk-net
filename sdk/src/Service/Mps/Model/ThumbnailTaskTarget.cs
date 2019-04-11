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

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Mps.Model
{

    /// <summary>
    ///  视频截图目标文件参数
    /// </summary>
    public class ThumbnailTaskTarget
    {

        ///<summary>
        /// 输入存放目标文件的 bucket
        ///Required:true
        ///</summary>
        [Required]
        public string DestBucket{ get; set; }
        ///<summary>
        /// 目标截图的Key的前缀, &#39;前缀-taskID-%04d(num).(format)&#39;, 默认: sourceKey
        ///</summary>
        public string DestKeyPrefix{ get; set; }
        ///<summary>
        /// 目标截图的格式 default: jpg
        ///</summary>
        public string Format{ get; set; }
        ///<summary>
        /// 目标截图的宽, 如果视频实际分辨率低于目标分辨率则按照实际分辨率输出 default: 0 代表源视频高 其他[8, 4096]
        ///</summary>
        public int? WidthInPixel{ get; set; }
        ///<summary>
        /// 目标截图的高, 如果视频实际分辨率低于目标分辨率则按照实际分辨率输出 default: 0 代表源视频高 其他[8, 4096]
        ///</summary>
        public int? HeightInPixel{ get; set; }
        ///<summary>
        /// 目标截图的Key的集合 (readonly)
        ///</summary>
        public List<string> Keys{ get; set; }
    }
}
