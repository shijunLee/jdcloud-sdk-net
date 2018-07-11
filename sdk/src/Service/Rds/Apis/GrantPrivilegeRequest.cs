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
 * 账号管理
 * API related to Relational Database Service
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
using JDCloudSDK.Rds.Model;

namespace  JDCloudSDK.Rds.Apis
{

    /// <summary>
    /// 数据库账号授权
    /// </summary>
    public class GrantPrivilegeRequest : JdcloudRequest
    {
        ///<summary>
        ///账号的访问权限
        ///Required:true
        ///</summary>
        [Required]
        public List<AccountPrivilege> AccountPrivileges{ get; set; }

        ///<summary>
        ///地域代码
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        ///实例ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
        ///<summary>
        ///账户名
        ///Required:true
        ///</summary>
        [Required]
        public   string AccountName{ get; set; }
    }
}