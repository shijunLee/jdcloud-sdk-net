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


namespace JDCloudSDK.Cr.Model
{

    /// <summary>
    ///  authorizationData
    /// </summary>
    public class AuthorizationData
    {

        ///<summary>
        /// 基于base64编码的字符串，包含指定JCR registry的授权信息。解码后可用于docker login。
        ///</summary>
        public string AuthorizationToken{ get; set; }
        ///<summary>
        /// 用户直接使用的docker login 命令行
        ///</summary>
        public string LoginCmdLine{ get; set; }
        ///<summary>
        /// Unix 时钟，记录authorization token的过期时间。默认Authorization tokens有效期为12小时。
        ///</summary>
        public string ExpiresAt{ get; set; }
    }
}
