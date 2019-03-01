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
 * Image
 * 容器镜像服务镜像相关接口
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


namespace  JDCloudSDK.Containerregistry.Apis
{

    /// <summary>
    ///  删除镜像
        ///         /// imageDigest imageTag imageTagStatus 三者只能且必须传一个。
        ///         /// 可根据Tag状态删除Image，例如删除所有tagged的镜像。
        ///         /// digest和tag唯一表征单个镜像，其中imageDigest为sha256哈希，image manifest的digest。
        ///         /// 例如 sha256:examplee6d1e504117a17000003d3753086354a38375961f2e665416ef4b1b2f；image使用的tag, 如  &quot;precise&quot; 
        ///         ///  [MFA enabled]
    /// </summary>
    public class DeleteImageResponse : JdcloudResponse<DeleteImageResult>
    {
    }
}