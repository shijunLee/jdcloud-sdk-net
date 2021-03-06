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
    ///  forbiddenStreamHistoryItem
    /// </summary>
    public class ForbiddenStreamHistoryItem
    {

        ///<summary>
        /// 禁播流
        ///</summary>
        public string Stream{ get; set; }
        ///<summary>
        /// 封禁推流的app
        ///</summary>
        public string App{ get; set; }
        ///<summary>
        /// 禁播类型:forever永不禁播limit限时禁播
        ///</summary>
        public string Type{ get; set; }
        ///<summary>
        /// 禁播时长
        ///</summary>
        public long? Ttl{ get; set; }
        ///<summary>
        /// 开始禁播时间
        ///</summary>
        public string StartTime{ get; set; }
        ///<summary>
        /// 结束禁播时间
        ///</summary>
        public string EndTime{ get; set; }
    }
}
