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


namespace JDCloudSDK.Jmr.Model
{

    /// <summary>
    ///  clusterListViewModel
    /// </summary>
    public class ClusterListViewModel
    {

        ///<summary>
        /// 用户名
        ///</summary>
        public string UserName{ get; set; }
        ///<summary>
        /// 主节点信息
        ///</summary>
        public string MasterNodeInfo{ get; set; }
        ///<summary>
        /// 主节点磁盘类型
        ///</summary>
        public string MasterNodeDiskType{ get; set; }
        ///<summary>
        /// 主节点磁盘容量
        ///</summary>
        public int? MasterNodeDiskVolume{ get; set; }
        ///<summary>
        /// 主节点数量
        ///</summary>
        public int? MasterNodeNumber{ get; set; }
        ///<summary>
        /// 主节点实例类型
        ///</summary>
        public string MasterInstanceType{ get; set; }
        ///<summary>
        /// 从节点信息
        ///</summary>
        public string SlaveNodeInfo{ get; set; }
        ///<summary>
        /// 从节点磁盘类型
        ///</summary>
        public string SlaveNodeDiskType{ get; set; }
        ///<summary>
        /// 从节点磁盘容量
        ///</summary>
        public int? SlaveNodeDiskVolume{ get; set; }
        ///<summary>
        /// 从节点数量
        ///</summary>
        public int? SlaveNodeNumber{ get; set; }
        ///<summary>
        /// 核心实例类型
        ///</summary>
        public string CoreInstanceType{ get; set; }
        ///<summary>
        /// 网络带宽
        ///</summary>
        public int? BandwidthOut{ get; set; }
        ///<summary>
        /// 数据中心位置
        ///</summary>
        public string DataCenter{ get; set; }
    }
}