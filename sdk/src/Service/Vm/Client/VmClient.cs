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
 * 云主机实例、镜像、规格类型、实例模板、配额相关的接口
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Vm.Apis;
using JDCloudSDK.Vm.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Vm.Client
{
    /// <summary>
    /// 云主机
    /// 云主机实例、镜像、规格类型、实例模板、配额相关的接口
    /// Vm Api 客户端
    ///</summary>
    public class VmClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private VmClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public VmClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
            this.environment = environment;
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="credentialsProvider">认证信息</param>
        public VmClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public VmClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.1
        ///</summary>
        public const string ClientVersion = "1.0.1";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "vm.jdcloud-api.com";
        private const string serviceName = "vm";
        private const string userAgent = userAgentPrefix + "/" + ClientVersion + " " + serviceName + "/" + apiVersion;


        private SDKEnvironment environment = new SDKEnvironment(defaultEndpoint);
        private CredentialsProvider credentialsProvider;
        private HttpRequestConfig httpRequestConfig;

        /// <summary>
        ///  获取证书信息
        ///</summary>
        public override CredentialsProvider CredentialsProvider   { get { return credentialsProvider; } }

        /// <summary>
        ///  获取http 客户端配置信息
        ///</summary>
        public override HttpRequestConfig HttpRequestConfig { get { return httpRequestConfig; } }

        /// <summary>
        ///  获取sdk环境配置信息
        ///</summary>
        public override SDKEnvironment SDKEnvironment { get { return environment; } }

        /// <summary>
        ///  获取用户自定义浏览器识别字符串
        ///</summary>
        public override string UserAgent { get { return userAgent; } }

        /// <summary>
        ///  获取服务名称
        ///</summary>
        public override string ServiceName { get { return serviceName; } }

        /// <summary>
        ///  获取版本号
        ///</summary>
        public override string Version { get { return apiVersion; } }



#if NET40||NET35
        /// <summary>
        /// 创建一个指定参数的启动模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateInstanceTemplateResponse CreateInstanceTemplate(CreateInstanceTemplateRequest request) {
            return  new CreateInstanceTemplateExecutor().Client(this).Execute<CreateInstanceTemplateResponse, CreateInstanceTemplateResult, CreateInstanceTemplateRequest>(request);
        }
#else
        /// <summary>
        /// 创建一个指定参数的启动模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateInstanceTemplateResponse> CreateInstanceTemplate(CreateInstanceTemplateRequest request) {
            return await new CreateInstanceTemplateExecutor().Client(this).Execute<CreateInstanceTemplateResponse, CreateInstanceTemplateResult, CreateInstanceTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 云主机挂载硬盘，主机和云盘没有未完成的任务时才可挂载，一个主机上最多可挂载4块数据盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AttachDiskResponse AttachDisk(AttachDiskRequest request) {
            return  new AttachDiskExecutor().Client(this).Execute<AttachDiskResponse, AttachDiskResult, AttachDiskRequest>(request);
        }
#else
        /// <summary>
        /// 云主机挂载硬盘，主机和云盘没有未完成的任务时才可挂载，一个主机上最多可挂载4块数据盘
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AttachDiskResponse> AttachDisk(AttachDiskRequest request) {
            return await new AttachDiskExecutor().Client(this).Execute<AttachDiskResponse, AttachDiskResult, AttachDiskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询镜像共享帐户列表，不能操作非私有镜像
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeImageMembersResponse DescribeImageMembers(DescribeImageMembersRequest request) {
            return  new DescribeImageMembersExecutor().Client(this).Execute<DescribeImageMembersResponse, DescribeImageMembersResult, DescribeImageMembersRequest>(request);
        }
#else
        /// <summary>
        /// 查询镜像共享帐户列表，不能操作非私有镜像
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeImageMembersResponse> DescribeImageMembers(DescribeImageMembersRequest request) {
            return await new DescribeImageMembersExecutor().Client(this).Execute<DescribeImageMembersResponse, DescribeImageMembersResult, DescribeImageMembersRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询镜像信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeImageResponse DescribeImage(DescribeImageRequest request) {
            return  new DescribeImageExecutor().Client(this).Execute<DescribeImageResponse, DescribeImageResult, DescribeImageRequest>(request);
        }
#else
        /// <summary>
        /// 查询镜像信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeImageResponse> DescribeImage(DescribeImageRequest request) {
            return await new DescribeImageExecutor().Client(this).Execute<DescribeImageResponse, DescribeImageResult, DescribeImageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 云主机使用指定镜像重置实例镜像，需要关机操作，
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RebuildInstanceResponse RebuildInstance(RebuildInstanceRequest request) {
            return  new RebuildInstanceExecutor().Client(this).Execute<RebuildInstanceResponse, RebuildInstanceResult, RebuildInstanceRequest>(request);
        }
#else
        /// <summary>
        /// 云主机使用指定镜像重置实例镜像，需要关机操作，
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RebuildInstanceResponse> RebuildInstance(RebuildInstanceRequest request) {
            return await new RebuildInstanceExecutor().Client(this).Execute<RebuildInstanceResponse, RebuildInstanceResult, RebuildInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 重启单个实例，只能重启running状态的实例，主机没有未完成的任务才可重启
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request) {
            return  new RebootInstanceExecutor().Client(this).Execute<RebootInstanceResponse, RebootInstanceResult, RebootInstanceRequest>(request);
        }
#else
        /// <summary>
        /// 重启单个实例，只能重启running状态的实例，主机没有未完成的任务才可重启
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RebootInstanceResponse> RebootInstance(RebootInstanceRequest request) {
            return await new RebootInstanceExecutor().Client(this).Execute<RebootInstanceResponse, RebootInstanceResult, RebootInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询启动模板详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceTemplateResponse DescribeInstanceTemplate(DescribeInstanceTemplateRequest request) {
            return  new DescribeInstanceTemplateExecutor().Client(this).Execute<DescribeInstanceTemplateResponse, DescribeInstanceTemplateResult, DescribeInstanceTemplateRequest>(request);
        }
#else
        /// <summary>
        /// 查询启动模板详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceTemplateResponse> DescribeInstanceTemplate(DescribeInstanceTemplateRequest request) {
            return await new DescribeInstanceTemplateExecutor().Client(this).Execute<DescribeInstanceTemplateResponse, DescribeInstanceTemplateResult, DescribeInstanceTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// &quot;共享镜像，最多可共享给20个帐户&quot;
        ///&quot;打包镜像暂不支持共享&quot;
        ///&quot;不能操作非私有镜像&quot;
        ///&quot;不能共享给自己&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ShareImageResponse ShareImage(ShareImageRequest request) {
            return  new ShareImageExecutor().Client(this).Execute<ShareImageResponse, ShareImageResult, ShareImageRequest>(request);
        }
#else
        /// <summary>
        /// &quot;共享镜像，最多可共享给20个帐户&quot;
        ///&quot;打包镜像暂不支持共享&quot;
        ///&quot;不能操作非私有镜像&quot;
        ///&quot;不能共享给自己&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ShareImageResponse> ShareImage(ShareImageRequest request) {
            return await new ShareImageExecutor().Client(this).Execute<ShareImageResponse, ShareImageResult, ShareImageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询镜像资源信息列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request) {
            return  new DescribeImagesExecutor().Client(this).Execute<DescribeImagesResponse, DescribeImagesResult, DescribeImagesRequest>(request);
        }
#else
        /// <summary>
        /// 查询镜像资源信息列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest request) {
            return await new DescribeImagesExecutor().Client(this).Execute<DescribeImagesResponse, DescribeImagesResult, DescribeImagesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 停止单个实例，只能停止running状态的实例，主机没有未完成的任务才可停止
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StopInstanceResponse StopInstance(StopInstanceRequest request) {
            return  new StopInstanceExecutor().Client(this).Execute<StopInstanceResponse, StopInstanceResult, StopInstanceRequest>(request);
        }
#else
        /// <summary>
        /// 停止单个实例，只能停止running状态的实例，主机没有未完成的任务才可停止
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StopInstanceResponse> StopInstance(StopInstanceRequest request) {
            return await new StopInstanceExecutor().Client(this).Execute<StopInstanceResponse, StopInstanceResult, StopInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询主机vnc
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest request) {
            return  new DescribeInstanceVncUrlExecutor().Client(this).Execute<DescribeInstanceVncUrlResponse, DescribeInstanceVncUrlResult, DescribeInstanceVncUrlRequest>(request);
        }
#else
        /// <summary>
        /// 查询主机vnc
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest request) {
            return await new DescribeInstanceVncUrlExecutor().Client(this).Execute<DescribeInstanceVncUrlResponse, DescribeInstanceVncUrlResult, DescribeInstanceVncUrlRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询启动模板列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceTemplatesResponse DescribeInstanceTemplates(DescribeInstanceTemplatesRequest request) {
            return  new DescribeInstanceTemplatesExecutor().Client(this).Execute<DescribeInstanceTemplatesResponse, DescribeInstanceTemplatesResult, DescribeInstanceTemplatesRequest>(request);
        }
#else
        /// <summary>
        /// 查询启动模板列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceTemplatesResponse> DescribeInstanceTemplates(DescribeInstanceTemplatesRequest request) {
            return await new DescribeInstanceTemplatesExecutor().Client(this).Execute<DescribeInstanceTemplatesResponse, DescribeInstanceTemplatesResult, DescribeInstanceTemplatesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 删除私有镜像
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteImageResponse DeleteImage(DeleteImageRequest request) {
            return  new DeleteImageExecutor().Client(this).Execute<DeleteImageResponse, DeleteImageResult, DeleteImageRequest>(request);
        }
#else
        /// <summary>
        /// 删除私有镜像
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteImageResponse> DeleteImage(DeleteImageRequest request) {
            return await new DeleteImageExecutor().Client(this).Execute<DeleteImageResponse, DeleteImageResult, DeleteImageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询云主机详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request) {
            return  new DescribeInstanceExecutor().Client(this).Execute<DescribeInstanceResponse, DescribeInstanceResult, DescribeInstanceRequest>(request);
        }
#else
        /// <summary>
        /// 查询云主机详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceResponse> DescribeInstance(DescribeInstanceRequest request) {
            return await new DescribeInstanceExecutor().Client(this).Execute<DescribeInstanceResponse, DescribeInstanceResult, DescribeInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// &quot;云主机变更实例规格，需要关机操作&quot;
        ///&quot;16年创建的云盘做系统盘的主机，一代与二代实例类型不允许相互调整&quot;
        ///&quot;本地盘做系统盘的主机，一代与二代实例类型不允许相互调整&quot;
        ///&quot;ag中的主机，一代与二代实例类型不允许相互调整&quot;
        ///&quot;变更后实例规格的网卡数量限制，要支持当前主机的网卡数量，如不支持，需要缷载网卡后再变更实例规格&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResizeInstanceResponse ResizeInstance(ResizeInstanceRequest request) {
            return  new ResizeInstanceExecutor().Client(this).Execute<ResizeInstanceResponse, ResizeInstanceResult, ResizeInstanceRequest>(request);
        }
#else
        /// <summary>
        /// &quot;云主机变更实例规格，需要关机操作&quot;
        ///&quot;16年创建的云盘做系统盘的主机，一代与二代实例类型不允许相互调整&quot;
        ///&quot;本地盘做系统盘的主机，一代与二代实例类型不允许相互调整&quot;
        ///&quot;ag中的主机，一代与二代实例类型不允许相互调整&quot;
        ///&quot;变更后实例规格的网卡数量限制，要支持当前主机的网卡数量，如不支持，需要缷载网卡后再变更实例规格&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResizeInstanceResponse> ResizeInstance(ResizeInstanceRequest request) {
            return await new ResizeInstanceExecutor().Client(this).Execute<ResizeInstanceResponse, ResizeInstanceResult, ResizeInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询（虚机、镜像、密钥、模板）配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotasResponse DescribeQuotas(DescribeQuotasRequest request) {
            return  new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request);
        }
#else
        /// <summary>
        /// 查询（虚机、镜像、密钥、模板）配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest request) {
            return await new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// &quot;虚机创建私有镜像&quot;
        ///&quot;虚机状态必须为stopped&quot;
        ///&quot;如果虚机上有挂载数据盘，默认会将数据盘创建快照，生成打包镜像&quot;
        ///&quot;主机没有未完成的任务才可制作镜像&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateImageResponse CreateImage(CreateImageRequest request) {
            return  new CreateImageExecutor().Client(this).Execute<CreateImageResponse, CreateImageResult, CreateImageRequest>(request);
        }
#else
        /// <summary>
        /// &quot;虚机创建私有镜像&quot;
        ///&quot;虚机状态必须为stopped&quot;
        ///&quot;如果虚机上有挂载数据盘，默认会将数据盘创建快照，生成打包镜像&quot;
        ///&quot;主机没有未完成的任务才可制作镜像&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateImageResponse> CreateImage(CreateImageRequest request) {
            return await new CreateImageExecutor().Client(this).Execute<CreateImageResponse, CreateImageResult, CreateImageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询云主机列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request) {
            return  new DescribeInstancesExecutor().Client(this).Execute<DescribeInstancesResponse, DescribeInstancesResult, DescribeInstancesRequest>(request);
        }
#else
        /// <summary>
        /// 查询云主机列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstancesResponse> DescribeInstances(DescribeInstancesRequest request) {
            return await new DescribeInstancesExecutor().Client(this).Execute<DescribeInstancesResponse, DescribeInstancesResult, DescribeInstancesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 创建一台或多台指定配置的实例&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/3383/isCatalog/1&quot;&gt;参数详细说明&lt;/a&gt;
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateInstancesResponse CreateInstances(CreateInstancesRequest request) {
            return  new CreateInstancesExecutor().Client(this).Execute<CreateInstancesResponse, CreateInstancesResult, CreateInstancesRequest>(request);
        }
#else
        /// <summary>
        /// 创建一台或多台指定配置的实例&lt;a href&#x3D;&quot;https://www.jdcloud.com/help/detail/3383/isCatalog/1&quot;&gt;参数详细说明&lt;/a&gt;
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateInstancesResponse> CreateInstances(CreateInstancesRequest request) {
            return await new CreateInstancesExecutor().Client(this).Execute<CreateInstancesResponse, CreateInstancesResult, CreateInstancesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 取消共享镜像，不能操作非私有镜像
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UnShareImageResponse UnShareImage(UnShareImageRequest request) {
            return  new UnShareImageExecutor().Client(this).Execute<UnShareImageResponse, UnShareImageResult, UnShareImageRequest>(request);
        }
#else
        /// <summary>
        /// 取消共享镜像，不能操作非私有镜像
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UnShareImageResponse> UnShareImage(UnShareImageRequest request) {
            return await new UnShareImageExecutor().Client(this).Execute<UnShareImageResponse, UnShareImageResult, UnShareImageRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 修改主机密码，主机没有未完成的任务时才可操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstancePasswordResponse ModifyInstancePassword(ModifyInstancePasswordRequest request) {
            return  new ModifyInstancePasswordExecutor().Client(this).Execute<ModifyInstancePasswordResponse, ModifyInstancePasswordResult, ModifyInstancePasswordRequest>(request);
        }
#else
        /// <summary>
        /// 修改主机密码，主机没有未完成的任务时才可操作
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstancePasswordResponse> ModifyInstancePassword(ModifyInstancePasswordRequest request) {
            return await new ModifyInstancePasswordExecutor().Client(this).Execute<ModifyInstancePasswordResponse, ModifyInstancePasswordResult, ModifyInstancePasswordRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 修改主机信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request) {
            return  new ModifyInstanceAttributeExecutor().Client(this).Execute<ModifyInstanceAttributeResponse, ModifyInstanceAttributeResult, ModifyInstanceAttributeRequest>(request);
        }
#else
        /// <summary>
        /// 修改主机信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttribute(ModifyInstanceAttributeRequest request) {
            return await new ModifyInstanceAttributeExecutor().Client(this).Execute<ModifyInstanceAttributeResponse, ModifyInstanceAttributeResult, ModifyInstanceAttributeRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 删除实例模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteInstanceTemplateResponse DeleteInstanceTemplate(DeleteInstanceTemplateRequest request) {
            return  new DeleteInstanceTemplateExecutor().Client(this).Execute<DeleteInstanceTemplateResponse, DeleteInstanceTemplateResult, DeleteInstanceTemplateRequest>(request);
        }
#else
        /// <summary>
        /// 删除实例模板
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteInstanceTemplateResponse> DeleteInstanceTemplate(DeleteInstanceTemplateRequest request) {
            return await new DeleteInstanceTemplateExecutor().Client(this).Execute<DeleteInstanceTemplateResponse, DeleteInstanceTemplateResult, DeleteInstanceTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 云主机解绑公网IP 解绑的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return  new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        /// 云主机解绑公网IP 解绑的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DisassociateElasticIpResponse> DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return await new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 修改一个实例模板的信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public UpdateInstanceTemplateResponse UpdateInstanceTemplate(UpdateInstanceTemplateRequest request) {
            return  new UpdateInstanceTemplateExecutor().Client(this).Execute<UpdateInstanceTemplateResponse, UpdateInstanceTemplateResult, UpdateInstanceTemplateRequest>(request);
        }
#else
        /// <summary>
        /// 修改一个实例模板的信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<UpdateInstanceTemplateResponse> UpdateInstanceTemplate(UpdateInstanceTemplateRequest request) {
            return await new UpdateInstanceTemplateExecutor().Client(this).Execute<UpdateInstanceTemplateResponse, UpdateInstanceTemplateResult, UpdateInstanceTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询镜像限制
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeImageConstraintsResponse DescribeImageConstraints(DescribeImageConstraintsRequest request) {
            return  new DescribeImageConstraintsExecutor().Client(this).Execute<DescribeImageConstraintsResponse, DescribeImageConstraintsResult, DescribeImageConstraintsRequest>(request);
        }
#else
        /// <summary>
        /// 查询镜像限制
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeImageConstraintsResponse> DescribeImageConstraints(DescribeImageConstraintsRequest request) {
            return await new DescribeImageConstraintsExecutor().Client(this).Execute<DescribeImageConstraintsResponse, DescribeImageConstraintsResult, DescribeImageConstraintsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 修改（虚机、镜像、密钥、模板）配额，内部接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyQuotaResponse ModifyQuota(ModifyQuotaRequest request) {
            return  new ModifyQuotaExecutor().Client(this).Execute<ModifyQuotaResponse, ModifyQuotaResult, ModifyQuotaRequest>(request);
        }
#else
        /// <summary>
        /// 修改（虚机、镜像、密钥、模板）配额，内部接口
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyQuotaResponse> ModifyQuota(ModifyQuotaRequest request) {
            return await new ModifyQuotaExecutor().Client(this).Execute<ModifyQuotaResponse, ModifyQuotaResult, ModifyQuotaRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询主机模板信息是否可用,信息是否准确
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public VerifyInstanceTemplateResponse VerifyInstanceTemplate(VerifyInstanceTemplateRequest request) {
            return  new VerifyInstanceTemplateExecutor().Client(this).Execute<VerifyInstanceTemplateResponse, VerifyInstanceTemplateResult, VerifyInstanceTemplateRequest>(request);
        }
#else
        /// <summary>
        /// 查询主机模板信息是否可用,信息是否准确
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<VerifyInstanceTemplateResponse> VerifyInstanceTemplate(VerifyInstanceTemplateRequest request) {
            return await new VerifyInstanceTemplateExecutor().Client(this).Execute<VerifyInstanceTemplateResponse, VerifyInstanceTemplateResult, VerifyInstanceTemplateRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 启动单个实例，只能启动stopped状态的实例，主机没有未完成的任务才可启动
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StartInstanceResponse StartInstance(StartInstanceRequest request) {
            return  new StartInstanceExecutor().Client(this).Execute<StartInstanceResponse, StartInstanceResult, StartInstanceRequest>(request);
        }
#else
        /// <summary>
        /// 启动单个实例，只能启动stopped状态的实例，主机没有未完成的任务才可启动
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StartInstanceResponse> StartInstance(StartInstanceRequest request) {
            return await new StartInstanceExecutor().Client(this).Execute<StartInstanceResponse, StartInstanceResult, StartInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// &quot;删除单个实例&quot;
        ///&quot;主机状态必须为停止状态、同时主机没有未完成的任务才可删除&quot;
        ///&quot;包年包月未到期的主机不能删除&quot;
        ///&quot;如果主机中挂载了数据盘，并且设置了AutoDelete属性为true，那么数据盘会随主机一起删除&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request) {
            return  new DeleteInstanceExecutor().Client(this).Execute<DeleteInstanceResponse, DeleteInstanceResult, DeleteInstanceRequest>(request);
        }
#else
        /// <summary>
        /// &quot;删除单个实例&quot;
        ///&quot;主机状态必须为停止状态、同时主机没有未完成的任务才可删除&quot;
        ///&quot;包年包月未到期的主机不能删除&quot;
        ///&quot;如果主机中挂载了数据盘，并且设置了AutoDelete属性为true，那么数据盘会随主机一起删除&quot;
        ///
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteInstanceResponse> DeleteInstance(DeleteInstanceRequest request) {
            return await new DeleteInstanceExecutor().Client(this).Execute<DeleteInstanceResponse, DeleteInstanceResult, DeleteInstanceRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 云主机绑定公网IP 绑定的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request) {
            return  new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        /// 云主机绑定公网IP 绑定的是主网卡、主内网IP对应的弹性IP
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AssociateElasticIpResponse> AssociateElasticIp(AssociateElasticIpRequest request) {
            return await new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 云主机缷载硬盘，主机和云盘没有未完成的任务时才可缷载
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DetachDiskResponse DetachDisk(DetachDiskRequest request) {
            return  new DetachDiskExecutor().Client(this).Execute<DetachDiskResponse, DetachDiskResult, DetachDiskRequest>(request);
        }
#else
        /// <summary>
        /// 云主机缷载硬盘，主机和云盘没有未完成的任务时才可缷载
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DetachDiskResponse> DetachDisk(DetachDiskRequest request) {
            return await new DetachDiskExecutor().Client(this).Execute<DetachDiskResponse, DetachDiskResult, DetachDiskRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 查询实例类型资源信息列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeInstanceTypesResponse DescribeInstanceTypes(DescribeInstanceTypesRequest request) {
            return  new DescribeInstanceTypesExecutor().Client(this).Execute<DescribeInstanceTypesResponse, DescribeInstanceTypesResult, DescribeInstanceTypesRequest>(request);
        }
#else
        /// <summary>
        /// 查询实例类型资源信息列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypes(DescribeInstanceTypesRequest request) {
            return await new DescribeInstanceTypesExecutor().Client(this).Execute<DescribeInstanceTypesResponse, DescribeInstanceTypesResult, DescribeInstanceTypesRequest>(request);
        }
#endif

            /// <summary>
            ///  默认VmClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>vmClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>vmClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>vmClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造VmClient 对象
                ///</summary>
                VmClient Build();
            }

            /// <summary>
            ///  默认VmClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                /// VmClient service client
                /// </summary>
                private  VmClient vmClient;

                /// <summary>
                ///  默认VmClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    vmClient = new VmClient();
                }

                /// <summary>
                ///  构造VmClient 对象
                ///</summary>
                public VmClient Build()
                {
                    if (vmClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        vmClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (vmClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("VmClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (vmClient.HttpRequestConfig == null)
                    {
                        vmClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (vmClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("VmClient build error: http request config not set");
                        }
                    }
                    return vmClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>vmClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    vmClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>vmClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    vmClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>vmClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    vmClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}