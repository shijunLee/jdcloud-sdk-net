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


namespace JDCloudSDK.Cps.Model
{

    /// <summary>
    ///  raid
    /// </summary>
    public class Raid
    {

        ///<summary>
        /// 磁盘类型, 如 system/data
        ///</summary>
        public string VolumeType{ get; set; }
        ///<summary>
        /// 设备详情
        ///</summary>
        public string VolumeDetail{ get; set; }
        ///<summary>
        /// RAID类型ID
        ///</summary>
        public string RaidTypeId{ get; set; }
        ///<summary>
        /// RAID类型, 如 NORAID, RAID0, RAID1
        ///</summary>
        public string RaidType{ get; set; }
        ///<summary>
        /// 云物理服务器类型, 如 cps.c.normal
        ///</summary>
        public string DeviceType{ get; set; }
        ///<summary>
        /// RAID类型描述
        ///</summary>
        public string Description{ get; set; }
    }
}
