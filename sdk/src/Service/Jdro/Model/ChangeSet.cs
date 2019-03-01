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


namespace JDCloudSDK.Jdro.Model
{

    /// <summary>
    ///  changeSet
    /// </summary>
    public class ChangeSet
    {

        ///<summary>
        /// 更改集操作
        ///</summary>
        public string Action{ get; set; }
        ///<summary>
        /// 更改信息
        ///</summary>
        public string ChangeInfo{ get; set; }
        ///<summary>
        /// changeset的详细信息
        ///</summary>
        public Dictionary<string,Change> ChangeMap{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public DateTime? CreateTime{ get; set; }
        ///<summary>
        /// 更改集描述
        ///</summary>
        public string Describe{ get; set; }
        ///<summary>
        /// Id
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 是否执行
        ///</summary>
        public long? IsRun{ get; set; }
        ///<summary>
        /// 更改集名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 地域信息
        ///</summary>
        public string Region{ get; set; }
        ///<summary>
        /// 执行时间
        ///</summary>
        public DateTime? RunTime{ get; set; }
        ///<summary>
        /// 对应资源栈ID
        ///</summary>
        public string StackId{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 状态原因
        ///</summary>
        public string StatusReason{ get; set; }
        ///<summary>
        /// 对应模板ID
        ///</summary>
        public string TemplateId{ get; set; }
    }
}
