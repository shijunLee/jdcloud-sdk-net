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


namespace JDCloudSDK.Ipanti.Model
{

    /// <summary>
    ///  cCProtectionRule
    /// </summary>
    public class CCProtectionRule
    {

        ///<summary>
        /// CC 防护规则 ID
        ///</summary>
        public long? Id{ get; set; }
        ///<summary>
        /// CC 防护规则对应的网站规则 ID
        ///</summary>
        public long? WebRuleId{ get; set; }
        ///<summary>
        /// CC 防护规则对应的实例 ID
        ///</summary>
        public long? InstanceId{ get; set; }
        ///<summary>
        /// CC 防护规则名称, 30 字符以内
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// CC 防护规则状态: 0: 关闭, 1: 开启
        ///</summary>
        public int? Enable{ get; set; }
        ///<summary>
        /// uri, 以 / 开头, 200 字符以内
        ///</summary>
        public string Uri{ get; set; }
        ///<summary>
        /// 匹配 uri 类型, 0: 精确匹配, 1: 前缀匹配
        ///</summary>
        public int? MatchType{ get; set; }
        ///<summary>
        /// 检测周期, 单位为秒, 取值范围[5, 10800]
        ///</summary>
        public long? DetectPeriod{ get; set; }
        ///<summary>
        /// ip 访问次数, 取值范围[2, 2000]
        ///</summary>
        public long? SingleIpLimit{ get; set; }
        ///<summary>
        /// 阻断类型, 1: 封禁, 2: 人机交互
        ///</summary>
        public int? BlockType{ get; set; }
        ///<summary>
        /// 阻断持续时间, 单位为分钟, 取值范围[1, 1440]
        ///</summary>
        public long? BlockTime{ get; set; }
    }
}
