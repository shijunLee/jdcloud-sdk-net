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


namespace JDCloudSDK.Jdfusion.Model
{

    /// <summary>
    ///  镜像信息
    /// </summary>
    public class ImageInfo
    {

        ///<summary>
        /// 镜像ID
        ///</summary>
        public string Id{ get; set; }
        ///<summary>
        /// 镜像名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        /// 镜像描述
        ///</summary>
        public string Description{ get; set; }
        ///<summary>
        /// 镜像架构
        ///</summary>
        public string Architecture{ get; set; }
        ///<summary>
        /// 创建时间
        ///</summary>
        public string CreatedTime{ get; set; }
        ///<summary>
        /// 镜像来源
        ///</summary>
        public string ImageSource{ get; set; }
        ///<summary>
        /// 镜像操作系统类型
        ///</summary>
        public string OsType{ get; set; }
        ///<summary>
        /// 操作系统平台
        ///</summary>
        public string Platform{ get; set; }
        ///<summary>
        /// 镜像复制和转换时的进度，仅显示数值，单位为百分比
        ///</summary>
        public string Progress{ get; set; }
        ///<summary>
        /// 镜像大小 单位MB
        ///</summary>
        public int? Size{ get; set; }
        ///<summary>
        /// 状态
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        /// 云注册信息ID
        ///</summary>
        public string CloudID{ get; set; }
    }
}
