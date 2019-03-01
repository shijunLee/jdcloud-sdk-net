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


namespace JDCloudSDK.Monitor.Model
{

    /// <summary>
    ///  groupInfo
    /// </summary>
    public class GroupInfo
    {

        ///<summary>
        /// 监控图的展示方式
        ///</summary>
        public List<Chart> Charts{ get; set; }
        ///<summary>
        /// 分组groupCode
        ///</summary>
        public string GroupCode{ get; set; }
        ///<summary>
        /// 分组名称
        ///</summary>
        public string GroupName{ get; set; }
        ///<summary>
        /// 分组内的metric列表
        ///</summary>
        public List<string> Metrics{ get; set; }
        ///<summary>
        /// 分组下metric对应的tags
        ///</summary>
        public Dictionary<string,string> Tags{ get; set; }
        ///<summary>
        /// 分组的webCode
        ///</summary>
        public string WebCode{ get; set; }
    }
}
