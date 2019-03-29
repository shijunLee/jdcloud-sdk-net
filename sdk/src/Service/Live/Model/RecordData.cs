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


namespace JDCloudSDK.Live.Model
{

    /// <summary>
    ///  recordData
    /// </summary>
    public class RecordData
    {

        ///<summary>
        /// 推流域名
        ///</summary>
        public string PublishDomain{ get; set; }
        ///<summary>
        /// 应用名称
        ///</summary>
        public string AppName{ get; set; }
        ///<summary>
        /// 流名称
        ///</summary>
        public string StreamName{ get; set; }
        ///<summary>
        /// 日期:
        /// - yyyyMMdd
        /// - 示例: 20190308
        /// 
        ///</summary>
        public string Date{ get; set; }
        ///<summary>
        /// 录制时长:
        /// - 单位: 分钟
        /// - 精确两位小数
        /// 
        ///</summary>
        public double? Total{ get; set; }
        ///<summary>
        /// 明细
        ///</summary>
        public List<RecordDetail> Detail{ get; set; }
    }
}