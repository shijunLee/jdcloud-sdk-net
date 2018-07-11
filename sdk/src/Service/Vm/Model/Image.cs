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


namespace JDCloudSDK.Vm.Model
{

    /// <summary>
    /// image
    /// </summary>
    public class Image
    {

        ///<summary>
        ///镜像ID
        ///</summary>
        public string ImageId{ get; set; }
        ///<summary>
        ///镜像名称
        ///</summary>
        public string Name{ get; set; }
        ///<summary>
        ///操作系统发行版，[suse, debian, ubuntu, centos, windows-server]
        ///</summary>
        public string Platform{ get; set; }
        ///<summary>
        ///操作系统版本号
        ///</summary>
        public string OsVersion{ get; set; }
        ///<summary>
        ///镜像架构 i386, x86_64
        ///</summary>
        public string Architecture{ get; set; }
        ///<summary>
        ///镜像系统盘大小
        ///</summary>
        public int? SystemDiskSizeGB{ get; set; }
        ///<summary>
        ///镜像来源 jcloud：官方镜像 marketplace：镜像市场镜像 self：用户自己的镜像 shared：其他用户分享的镜像
        ///</summary>
        public string ImageSource{ get; set; }
        ///<summary>
        ///镜像的操作系统类型，[windows, linux]
        ///</summary>
        public string OsType{ get; set; }
        ///<summary>
        ///镜像状态, [pending, ready, deleting, error]
        ///</summary>
        public string Status{ get; set; }
        ///<summary>
        ///创建时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        ///镜像本身大小
        ///</summary>
        public int? SizeMB{ get; set; }
        ///<summary>
        ///镜像描述
        ///</summary>
        public string Desc{ get; set; }
        ///<summary>
        ///打包镜像数据盘映射信息
        ///</summary>
        public List<InstanceDiskAttachment> DataDisks{ get; set; }
    }
}