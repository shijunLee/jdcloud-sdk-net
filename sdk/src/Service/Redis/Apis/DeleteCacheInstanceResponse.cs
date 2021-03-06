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
 * 缓存Redis实例接口
 * 缓存Redis实例相关接口
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


namespace  JDCloudSDK.Redis.Apis
{

    /// <summary>
    ///  删除按配置计费、或包年包月已到期的单个缓存Redis实例，包年包月未到期不可删除
        ///         /// 只有处于运行&lt;b&gt;running&lt;/b&gt;或者错误&lt;b&gt;error&lt;/b&gt;状态的可以删除，其余状态不可以删除
        ///         /// 白名单用户不能删除包年包月已到期的云主机
        ///         /// 
    /// </summary>
    public class DeleteCacheInstanceResponse : JdcloudResponse<DeleteCacheInstanceResult>
    {
    }
}