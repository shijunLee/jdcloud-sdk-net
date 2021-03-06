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


using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDCloudSDK.Vm.Client
{

    /// <summary>
    ///  为云主机创建私有镜像。云主机状态必须为&lt;b&gt;stopped&lt;/b&gt;。&lt;br&gt;
        /// 云主机没有正在进行中的任务才可制作镜像。&lt;br&gt;
        /// 制作镜像以备份系统盘为基础，在此之上可选择全部或部分挂载数据盘制作整机镜像（如不做任何更改将默认制作整机镜像），制作镜像过程会为所挂载云硬盘创建快照并与镜像关联。&lt;br&gt;
        /// 调用接口后，需要等待镜像状态变为&lt;b&gt;ready&lt;/b&gt;后，才能正常使用镜像。
        /// 
    /// </summary>
    public class CreateImageExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  为云主机创建私有镜像。云主机状态必须为&lt;b&gt;stopped&lt;/b&gt;。&lt;br&gt;
        /// 云主机没有正在进行中的任务才可制作镜像。&lt;br&gt;
        /// 制作镜像以备份系统盘为基础，在此之上可选择全部或部分挂载数据盘制作整机镜像（如不做任何更改将默认制作整机镜像），制作镜像过程会为所挂载云硬盘创建快照并与镜像关联。&lt;br&gt;
        /// 调用接口后，需要等待镜像状态变为&lt;b&gt;ready&lt;/b&gt;后，才能正常使用镜像。
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "POST";
            }
        }
        /// <summary>
        ///  为云主机创建私有镜像。云主机状态必须为&lt;b&gt;stopped&lt;/b&gt;。&lt;br&gt;
        /// 云主机没有正在进行中的任务才可制作镜像。&lt;br&gt;
        /// 制作镜像以备份系统盘为基础，在此之上可选择全部或部分挂载数据盘制作整机镜像（如不做任何更改将默认制作整机镜像），制作镜像过程会为所挂载云硬盘创建快照并与镜像关联。&lt;br&gt;
        /// 调用接口后，需要等待镜像状态变为&lt;b&gt;ready&lt;/b&gt;后，才能正常使用镜像。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/instances/{instanceId}:createImage";
            }
        }
    }
}
