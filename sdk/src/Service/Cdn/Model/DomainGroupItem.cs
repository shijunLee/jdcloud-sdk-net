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


namespace JDCloudSDK.Cdn.Model
{

    /// <summary>
    ///  domainGroupItem
    /// </summary>
    public class DomainGroupItem
    {

        ///<summary>
        /// 域名组成员
        ///</summary>
        public List<string> Domains{ get; set; }
        ///<summary>
        /// 主域名
        ///</summary>
        public string PrimaryDomain{ get; set; }
        ///<summary>
        /// 是否共享缓存
        ///</summary>
        public string ShareCache{ get; set; }
        ///<summary>
        /// 域名组名称
        ///</summary>
        public string DomainGroupName{ get; set; }
    }
}
