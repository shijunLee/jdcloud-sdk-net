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
 * 
 * 
 *
 * 
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;

using JDCloudSDK.Core.Annotation;

namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  addTagsSpec
    /// </summary>
    public class AddTagsSpec
    {

        ///<summary>
        /// 应用码。调用此API前需找云监控提供
        ///Required:true
        ///</summary>
        [Required]
        public string AppCode{ get; set; }
        ///<summary>
        /// 组id。须确保在一个APP范围内全局唯一
        ///Required:true
        ///</summary>
        [Required]
        public string GroupCode{ get; set; }
        ///<summary>
        /// 资源列表。总资源不能超过100个
        ///Required:true
        ///</summary>
        [Required]
        public List<string> ResourceIds{ get; set; }
        ///<summary>
        /// 资源的产品线
        ///Required:true
        ///</summary>
        [Required]
        public string ServiceCode{ get; set; }
        ///<summary>
        /// 标签名称。调用此API前需要与云监控确认可以使用的标签名称
        ///Required:true
        ///</summary>
        [Required]
        public string TagK{ get; set; }
        ///<summary>
        /// 标签值
        ///Required:true
        ///</summary>
        [Required]
        public string TagV{ get; set; }
    }
}
