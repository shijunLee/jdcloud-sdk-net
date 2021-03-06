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
    ///  slowLogAttributes
    /// </summary>
    public class SlowLogAttributes
    {

        ///<summary>
        /// 数据库名，表示该SQL是在哪个数据库中执行的
        ///</summary>
        public string DbName{ get; set; }
        ///<summary>
        /// SQL语句
        ///</summary>
        public string Sql{ get; set; }
        ///<summary>
        /// SQL语句执行的开始时间，格式为YYYY-MM-DD hh:mm:ss
        ///</summary>
        public string ExecutionTime{ get; set; }
        ///<summary>
        /// SQL语句执行的时长，单位秒
        ///</summary>
        public float? ElapsedTime{ get; set; }
        ///<summary>
        /// SQL语句等待锁的时间，单位秒
        ///</summary>
        public float? LockTime{ get; set; }
        ///<summary>
        /// SQL语句扫描的行数
        ///</summary>
        public int? RowsExamined{ get; set; }
        ///<summary>
        /// SQL语句返回的行数
        ///</summary>
        public int? RowsReturned{ get; set; }
    }
}
