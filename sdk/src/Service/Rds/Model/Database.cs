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


namespace JDCloudSDK.Rds.Model
{

    /// <summary>
    ///  database
    /// </summary>
    public class Database
    {

        ///<summary>
        /// 数据库名称，具体规则可参见帮助中心文档:[名称及密码限制](../../../documentation/Cloud-Database-and-Cache/RDS/Introduction/Restrictions/SQLServer-Restrictions.md)
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        /// 数据库状态，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)&lt;br&gt;- **MySQL：不支持，不返回该字段**&lt;br&gt;- **SQL Server：返回该字段**
        ///</summary>
        public string DbStatus{ get; set; }
        ///<summary>
        /// 字符集，参见[枚举参数定义](../Enum-Definitions/Enum-Definitions.md)
        ///</summary>
        public string CharacterSetName{ get; set; }
        ///<summary>
        /// 该数据库相关账户权限列表
        ///</summary>
        public List<DBAccessPrivilege> AccessPrivilege{ get; set; }
    }
}
