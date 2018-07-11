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


namespace JDCloudSDK.Mongodb.Model
{

    /// <summary>
    /// backup
    /// </summary>
    public class Backup
    {

        ///<summary>
        ///备份ID
        ///</summary>
        public string BackupId{ get; set; }
        ///<summary>
        ///备份名称
        ///</summary>
        public string BackupName{ get; set; }
        ///<summary>
        ///备份所属实例ID
        ///</summary>
        public string InstanceId{ get; set; }
        ///<summary>
        ///备份状态，Waiting(等待中)、Running(备份中)、Finished(已完成)、(Failed错误)
        ///</summary>
        public string BackupStatus{ get; set; }
        ///<summary>
        ///备份开始时间
        ///</summary>
        public string BackupStartTime{ get; set; }
        ///<summary>
        ///备份结束时间
        ///</summary>
        public string BackupEndTime{ get; set; }
        ///<summary>
        ///备份模式，Automated(系统自动备份)、Manual(手动备份)
        ///</summary>
        public string BackupMode{ get; set; }
        ///<summary>
        ///整个备份集大小，单位：Byte
        ///</summary>
        public int? BackupSizeByte{ get; set; }
    }
}