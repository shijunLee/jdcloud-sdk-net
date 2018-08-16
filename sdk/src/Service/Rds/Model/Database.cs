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
        /// 数据库名称
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        /// 数据库状态 building：创建中， running：运行中&lt;/br&gt;- SQL Server：支持&lt;/br&gt;- MySQL：暂不支持
        ///</summary>
        public string DbStatus{ get; set; }
        ///<summary>
        /// 字符集名称,mysql字符集包括：utf8；SQL Server字符集包括：Chinese_PRC_CI_AS、Chinese_PRC_CS_AS、SQL_Latin1_General_CP1_CI_AS、SQL_Latin1_General_CP1_CS_AS、Chinese_PRC_BIN
        ///</summary>
        public string CharacterSetName{ get; set; }
        ///<summary>
        /// 该数据库相关账户权限列表
        ///</summary>
        public List<DBAccessPrivilege> AccessPrivilege{ get; set; }
    }
}
