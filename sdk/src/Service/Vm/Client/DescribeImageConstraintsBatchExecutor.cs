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
 * 镜像
 * 关于主机镜像操作的相关接口
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
    ///  批量查询镜像的规格类型限制。&lt;br&gt;
        /// 通过此接口可以查看镜像不支持的规格类型。只有官方镜像、第三方镜像有规格类型的限制，个人的私有镜像没有此限制。
        /// 
    /// </summary>
    public class DescribeImageConstraintsBatchExecutor : JdcloudExecutor
    {
        /// <summary>
        ///  批量查询镜像的规格类型限制。&lt;br&gt;
        /// 通过此接口可以查看镜像不支持的规格类型。只有官方镜像、第三方镜像有规格类型的限制，个人的私有镜像没有此限制。
        /// 接口的Http 请求方法
        /// </summary>
        public override  string Method
        {
            get {
                return "GET";
            }
        }
        /// <summary>
        ///  批量查询镜像的规格类型限制。&lt;br&gt;
        /// 通过此接口可以查看镜像不支持的规格类型。只有官方镜像、第三方镜像有规格类型的限制，个人的私有镜像没有此限制。
        /// 接口的Http资源请求路径
        /// </summary>
        public override string Url
        {
            get {
            return "/regions/{regionId}/imageConstraints";
            }
        }
    }
}