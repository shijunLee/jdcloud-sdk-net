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


namespace JDCloudSDK.Baseanti.Model
{

    /// <summary>
    ///  ipResourceProtectInfo
    /// </summary>
    public class IpResourceProtectInfo
    {

        ///<summary>
        /// 攻击开始时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 攻击结束时间
        ///</summary>
        public string EndTime{ get; set; }
        ///<summary>
        /// 状态，0-&gt;完成，1-&gt;清洗，2-&gt;黑洞
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 触发原因，0-&gt;未知，1-&gt;四层，2-&gt;七层，3-&gt;四和7层
        ///</summary>
        public int? Cause{ get; set; }
    }
}
