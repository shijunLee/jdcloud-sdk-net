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

namespace JDCloudSDK.Kms.Model
{

    /// <summary>
    ///  secretVersionItem
    /// </summary>
    public class SecretVersionItem
    {

        ///<summary>
        /// 版本标识
        ///Required:true
        ///</summary>
        [Required]
        public string SecretVersion{ get; set; }
        ///<summary>
        /// Secret当前状态: 0: 已启用、1: 已禁用
        ///Required:true
        ///</summary>
        [Required]
        public int SecretStatus{ get; set; }
        ///<summary>
        /// Secret激活时间，采用ISO8601标准，格式为: YYYY-MM-DDTHH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public DateTime StartTime{ get; set; }
        ///<summary>
        /// 到期时间，采用ISO8601标准，格式为: YYYY-MM-DDTHH:mm:ssZ
        ///Required:true
        ///</summary>
        [Required]
        public DateTime ExpireTime{ get; set; }
        ///<summary>
        /// 密钥的内容
        ///Required:true
        ///</summary>
        [Required]
        public string SecretData{ get; set; }
    }
}