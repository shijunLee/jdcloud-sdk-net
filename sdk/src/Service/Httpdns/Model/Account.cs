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


namespace JDCloudSDK.Httpdns.Model
{

    /// <summary>
    ///  account
    /// </summary>
    public class Account
    {

        ///<summary>
        /// 索引id
        ///</summary>
        public int? Id{ get; set; }
        ///<summary>
        /// 用户名
        ///</summary>
        public string UserPin{ get; set; }
        ///<summary>
        /// 账户ID
        ///</summary>
        public string AccountId{ get; set; }
        ///<summary>
        /// 提供httpdns服务的IP
        ///</summary>
        public List<string> ServiceIp{ get; set; }
        ///<summary>
        /// httpdns服务的密钥
        ///</summary>
        public List<string> Key{ get; set; }
        ///<summary>
        /// httpdns服务的密钥的状态，同key的序号对应
        ///</summary>
        public List<int?> KeyStatus{ get; set; }
        ///<summary>
        /// 账户创建时间
        ///</summary>
        public long? CreateTime{ get; set; }
        ///<summary>
        /// 账户更新时间
        ///</summary>
        public long? UpdateTime{ get; set; }
        ///<summary>
        /// 非鉴权方式是否可以访问httpdns服务，0:不可以，1:可以
        ///</summary>
        public int? NoauthAccess{ get; set; }
        ///<summary>
        /// 账户最多可以创建的域名
        ///</summary>
        public int? DomainLimit{ get; set; }
        ///<summary>
        /// 账户状态，0:正常 1:使用80%流量，2:欠费 3:停服
        ///</summary>
        public int? AccountStatus{ get; set; }
    }
}