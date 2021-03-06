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
 * 云主机
 * 与主机操作相关的接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;
using JDCloudSDK.Core.Service;

using JDCloudSDK.Core.Annotation;
using JDCloudSDK.Vm.Model;

namespace  JDCloudSDK.Vm.Apis
{

    /// <summary>
    ///  为云主机创建私有镜像。云主机状态必须为&lt;b&gt;stopped&lt;/b&gt;。&lt;br&gt;
        ///         /// 云主机没有正在进行中的任务才可制作镜像。&lt;br&gt;
        ///         /// 制作镜像以备份系统盘为基础，在此之上可选择全部或部分挂载数据盘制作整机镜像（如不做任何更改将默认制作整机镜像），制作镜像过程会为所挂载云硬盘创建快照并与镜像关联。&lt;br&gt;
        ///         /// 调用接口后，需要等待镜像状态变为&lt;b&gt;ready&lt;/b&gt;后，才能正常使用镜像。
        ///         /// 
    /// </summary>
    public class CreateImageRequest : JdcloudRequest
    {
        ///<summary>
        /// 镜像名称，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///Required:true
        ///</summary>
        [Required]
        public   string Name{ get; set; }
        ///<summary>
        /// 镜像描述，&lt;a href&#x3D;&quot;http://docs.jdcloud.com/virtual-machines/api/general_parameters&quot;&gt;参考公共参数规范&lt;/a&gt;。
        ///Required:true
        ///</summary>
        [Required]
        public   string Description{ get; set; }
        ///<summary>
        /// 数据盘列表，可以在实例已挂载数据盘的基础上，额外增加新的快照、空盘、或排除云主机中的数据盘。
        ///</summary>
        public List<InstanceDiskAttachmentSpec> DataDisks{ get; set; }

        ///<summary>
        /// 地域ID
        ///Required:true
        ///</summary>
        [Required]
        public override  string RegionId{ get; set; }
        ///<summary>
        /// 云主机ID
        ///Required:true
        ///</summary>
        [Required]
        public   string InstanceId{ get; set; }
    }
}