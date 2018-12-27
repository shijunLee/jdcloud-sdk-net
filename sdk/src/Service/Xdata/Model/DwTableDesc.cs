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


namespace JDCloudSDK.Xdata.Model
{

    /// <summary>
    ///  dwTableDesc
    /// </summary>
    public class DwTableDesc
    {

        ///<summary>
        /// 数据库名
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        /// 表名
        ///</summary>
        public string TableName{ get; set; }
        ///<summary>
        /// 存储格式
        ///</summary>
        public string HiveFileFormat{ get; set; }
        ///<summary>
        /// 字段分隔符
        ///</summary>
        public string FieldsDelimit{ get; set; }
        ///<summary>
        /// 行分隔符
        ///</summary>
        public string LinesDelimit{ get; set; }
        ///<summary>
        /// 其他serde属性
        ///</summary>
        public object OtherSerdeProperties{ get; set; }
        ///<summary>
        /// 创建时间（自动生成）
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 所有者（自动生成）
        ///</summary>
        public string Owner{ get; set; }
        ///<summary>
        /// 描述信息
        ///</summary>
        public string Comments{ get; set; }
        ///<summary>
        /// 外表位置
        ///</summary>
        public string ExternalLocation{ get; set; }
        ///<summary>
        /// 参数
        ///</summary>
        public object Parameters{ get; set; }
        ///<summary>
        /// 列信息
        ///</summary>
        public List<DwTableRow> Rows{ get; set; }
    }
}