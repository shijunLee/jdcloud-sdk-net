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
 * JDCLOUD IAS Operateback Services API
 * 京东云联合登陆运营后台应用管理
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

namespace  JDCloudSDK.Ias.Apis
{

    /// <summary>
    ///  运营后台查询app
    /// </summary>
    public class AppsRequest : JdcloudRequest
    {
        ///<summary>
        /// pin
        ///Required:true
        ///</summary>
        [Required]
        public   string Pin{ get; set; }
        ///<summary>
        /// appName
        ///Required:true
        ///</summary>
        [Required]
        public   string AppName{ get; set; }
        ///<summary>
        /// clientId
        ///Required:true
        ///</summary>
        [Required]
        public   string ClientId{ get; set; }
        ///<summary>
        /// multiTenant
        ///Required:true
        ///</summary>
        [Required]
        public   bool MultiTenant{ get; set; }
        ///<summary>
        /// state
        ///Required:true
        ///</summary>
        [Required]
        public   string State{ get; set; }
        ///<summary>
        /// scope
        ///Required:true
        ///</summary>
        [Required]
        public   string Scope{ get; set; }
        ///<summary>
        /// startTime
        ///Required:true
        ///</summary>
        [Required]
        public   long StartTime{ get; set; }
        ///<summary>
        /// endTime
        ///Required:true
        ///</summary>
        [Required]
        public   long EndTime{ get; set; }
        ///<summary>
        /// accountType
        ///Required:true
        ///</summary>
        [Required]
        public   string AccountType{ get; set; }
        ///<summary>
        /// pageIndex
        ///Required:true
        ///</summary>
        [Required]
        public   int PageIndex{ get; set; }
        ///<summary>
        /// pageSize
        ///Required:true
        ///</summary>
        [Required]
        public   int PageSize{ get; set; }
        ///<summary>
        /// offset
        ///Required:true
        ///</summary>
        [Required]
        public   int Offset{ get; set; }
        ///<summary>
        /// RegionId
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
    }
}