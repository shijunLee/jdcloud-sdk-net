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
 * 资源栈
 * 资源栈相关操作接口
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

namespace  JDCloudSDK.Jdro.Apis
{

    /// <summary>
    ///  查询资源栈中资源列表
    /// </summary>
    public class DescribeStackResourcesRequest : JdcloudRequest
    {
        ///<summary>
        /// 当前所在页，默认为1
        ///</summary>
        public   long? PageNumber{ get; set; }
        ///<summary>
        /// 页面大小，默认为20；取值范围[1, 100]
        ///</summary>
        public   long? PageSize{ get; set; }
        ///<summary>
        /// 按照京东云产品线名称或者资源逻辑ID进行模糊搜索
        ///</summary>
        public   string Search{ get; set; }
        ///<summary>
        /// 只按照京东云产品线名称进行模糊搜索，比如VM，Disk等
        ///</summary>
        public   string Product{ get; set; }
        ///<summary>
        /// 地域 ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 资源栈 ID
        ///Required:true
        ///</summary>
        [Required]
        public   string StackId{ get; set; }
    }
}