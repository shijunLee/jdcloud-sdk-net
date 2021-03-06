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
 * pod
 * pod 服务
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Pod.Apis;
using JDCloudSDK.Pod.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Pod.Client
{
    /// <summary>
    ///  pod
    ///  pod 服务
    ///  Pod Api 客户端
    ///</summary>
    public class PodClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private PodClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public PodClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public PodClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public PodClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.9
        ///</summary>
        public const string ClientVersion = "1.0.9";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "pod.jdcloud-api.com";
        private const string serviceName = "pod";
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
        ///  查询资源的配额，支持：原生容器 pod 和 secret.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotaResponse DescribeQuota(DescribeQuotaRequest request) {
            return  new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request);
        }
#else
        /// <summary>
        ///  查询资源的配额，支持：原生容器 pod 和 secret.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotaResponse> DescribeQuota(DescribeQuotaRequest request) {
            return await new DescribeQuotaExecutor().Client(this).Execute<DescribeQuotaResponse, DescribeQuotaResult, DescribeQuotaRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询 secret 列表。&lt;br&gt; 
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecretsResponse DescribeSecrets(DescribeSecretsRequest request) {
            return  new DescribeSecretsExecutor().Client(this).Execute<DescribeSecretsResponse, DescribeSecretsResult, DescribeSecretsRequest>(request);
        }
#else
        /// <summary>
        ///  查询 secret 列表。&lt;br&gt; 
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecretsResponse> DescribeSecrets(DescribeSecretsRequest request) {
            return await new DescribeSecretsExecutor().Client(this).Execute<DescribeSecretsResponse, DescribeSecretsResult, DescribeSecretsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建一个 secret，用于存放镜像仓库机密相关信息。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateSecretResponse CreateSecret(CreateSecretRequest request) {
            return  new CreateSecretExecutor().Client(this).Execute<CreateSecretResponse, CreateSecretResult, CreateSecretRequest>(request);
        }
#else
        /// <summary>
        ///  创建一个 secret，用于存放镜像仓库机密相关信息。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateSecretResponse> CreateSecret(CreateSecretRequest request) {
            return await new CreateSecretExecutor().Client(this).Execute<CreateSecretResponse, CreateSecretResult, CreateSecretRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询单个 secret 详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request) {
            return  new DescribeSecretExecutor().Client(this).Execute<DescribeSecretResponse, DescribeSecretResult, DescribeSecretRequest>(request);
        }
#else
        /// <summary>
        ///  查询单个 secret 详情
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest request) {
            return await new DescribeSecretExecutor().Client(this).Execute<DescribeSecretResponse, DescribeSecretResult, DescribeSecretRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  pod 解绑公网 IP，解绑的是主网卡、主内网 IP 对应的弹性 IP.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DisassociateElasticIpResponse DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return  new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        ///  pod 解绑公网 IP，解绑的是主网卡、主内网 IP 对应的弹性 IP.
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DisassociateElasticIpResponse> DisassociateElasticIp(DisassociateElasticIpRequest request) {
            return await new DisassociateElasticIpExecutor().Client(this).Execute<DisassociateElasticIpResponse, DisassociateElasticIpResult, DisassociateElasticIpRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询单个容器日志
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetContainerLogsResponse GetContainerLogs(GetContainerLogsRequest request) {
            return  new GetContainerLogsExecutor().Client(this).Execute<GetContainerLogsResponse, GetContainerLogsResult, GetContainerLogsRequest>(request);
        }
#else
        /// <summary>
        ///  查询单个容器日志
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetContainerLogsResponse> GetContainerLogs(GetContainerLogsRequest request) {
            return await new GetContainerLogsExecutor().Client(this).Execute<GetContainerLogsResponse, GetContainerLogsResult, GetContainerLogsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  设置TTY大小
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResizeTTYResponse ResizeTTY(ResizeTTYRequest request) {
            return  new ResizeTTYExecutor().Client(this).Execute<ResizeTTYResponse, ResizeTTYResult, ResizeTTYRequest>(request);
        }
#else
        /// <summary>
        ///  设置TTY大小
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResizeTTYResponse> ResizeTTY(ResizeTTYRequest request) {
            return await new ResizeTTYExecutor().Client(this).Execute<ResizeTTYResponse, ResizeTTYResult, ResizeTTYRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询单个容器日志
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AttachResponse Attach(AttachRequest request) {
            return  new AttachExecutor().Client(this).Execute<AttachResponse, AttachResult, AttachRequest>(request);
        }
#else
        /// <summary>
        ///  查询单个容器日志
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AttachResponse> Attach(AttachRequest request) {
            return await new AttachExecutor().Client(this).Execute<AttachResponse, AttachResult, AttachRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  修改 pod 的 名称 和 描述。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ModifyPodAttributeResponse ModifyPodAttribute(ModifyPodAttributeRequest request) {
            return  new ModifyPodAttributeExecutor().Client(this).Execute<ModifyPodAttributeResponse, ModifyPodAttributeResult, ModifyPodAttributeRequest>(request);
        }
#else
        /// <summary>
        ///  修改 pod 的 名称 和 描述。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ModifyPodAttributeResponse> ModifyPodAttribute(ModifyPodAttributeRequest request) {
            return await new ModifyPodAttributeExecutor().Client(this).Execute<ModifyPodAttributeResponse, ModifyPodAttributeResult, ModifyPodAttributeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  pod 状态必须为 stopped、running 或 error状态。 &lt;br&gt;
        /// 按量付费的实例，如不主动删除将一直运行，不再使用的实例，可通过本接口主动停用。&lt;br&gt;
        /// 只能支持主动删除按量计费类型的实例。包年包月过期的 pod 也可以删除，其它的情况还请发工单系统。计费状态异常的容器无法删除。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeletePodResponse DeletePod(DeletePodRequest request) {
            return  new DeletePodExecutor().Client(this).Execute<DeletePodResponse, DeletePodResult, DeletePodRequest>(request);
        }
#else
        /// <summary>
        ///  pod 状态必须为 stopped、running 或 error状态。 &lt;br&gt;
        /// 按量付费的实例，如不主动删除将一直运行，不再使用的实例，可通过本接口主动停用。&lt;br&gt;
        /// 只能支持主动删除按量计费类型的实例。包年包月过期的 pod 也可以删除，其它的情况还请发工单系统。计费状态异常的容器无法删除。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeletePodResponse> DeletePod(DeletePodRequest request) {
            return await new DeletePodExecutor().Client(this).Execute<DeletePodResponse, DeletePodResult, DeletePodRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  执行exec，此接口需要升级Http协议到WebSocket
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExecStartResponse ExecStart(ExecStartRequest request) {
            return  new ExecStartExecutor().Client(this).Execute<ExecStartResponse, ExecStartResult, ExecStartRequest>(request);
        }
#else
        /// <summary>
        ///  执行exec，此接口需要升级Http协议到WebSocket
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExecStartResponse> ExecStart(ExecStartRequest request) {
            return await new ExecStartExecutor().Client(this).Execute<ExecStartResponse, ExecStartResult, ExecStartRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  pod 绑定弹性公网 IP，绑定的是主网卡、主内网IP对应的弹性IP. &lt;br&gt;
        /// 一个 pod 只能绑定一个弹性公网 IP(主网卡)，若主网卡已存在弹性公网IP，会返回错误。&lt;br&gt;
        /// 如果是黑名单中的用户，会返回错误。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public AssociateElasticIpResponse AssociateElasticIp(AssociateElasticIpRequest request) {
            return  new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request);
        }
#else
        /// <summary>
        ///  pod 绑定弹性公网 IP，绑定的是主网卡、主内网IP对应的弹性IP. &lt;br&gt;
        /// 一个 pod 只能绑定一个弹性公网 IP(主网卡)，若主网卡已存在弹性公网IP，会返回错误。&lt;br&gt;
        /// 如果是黑名单中的用户，会返回错误。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<AssociateElasticIpResponse> AssociateElasticIp(AssociateElasticIpRequest request) {
            return await new AssociateElasticIpExecutor().Client(this).Execute<AssociateElasticIpResponse, AssociateElasticIpResult, AssociateElasticIpRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  启动处于关闭状态的单个 pod ，处在任务执行中的 pod 无法启动。&lt;br&gt;
        /// pod 实例或其绑定的云盘已欠费时，容器将无法正常启动。&lt;br&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StartPodResponse StartPod(StartPodRequest request) {
            return  new StartPodExecutor().Client(this).Execute<StartPodResponse, StartPodResult, StartPodRequest>(request);
        }
#else
        /// <summary>
        ///  启动处于关闭状态的单个 pod ，处在任务执行中的 pod 无法启动。&lt;br&gt;
        /// pod 实例或其绑定的云盘已欠费时，容器将无法正常启动。&lt;br&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StartPodResponse> StartPod(StartPodRequest request) {
            return await new StartPodExecutor().Client(this).Execute<StartPodResponse, StartPodResult, StartPodRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  批量查询 pod 的详细信息&lt;br&gt;
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePodsResponse DescribePods(DescribePodsRequest request) {
            return  new DescribePodsExecutor().Client(this).Execute<DescribePodsResponse, DescribePodsResult, DescribePodsRequest>(request);
        }
#else
        /// <summary>
        ///  批量查询 pod 的详细信息&lt;br&gt;
        /// 此接口支持分页查询，默认每页20条。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePodsResponse> DescribePods(DescribePodsRequest request) {
            return await new DescribePodsExecutor().Client(this).Execute<DescribePodsResponse, DescribePodsResult, DescribePodsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取exec退出码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExecGetExitCodeResponse ExecGetExitCode(ExecGetExitCodeRequest request) {
            return  new ExecGetExitCodeExecutor().Client(this).Execute<ExecGetExitCodeResponse, ExecGetExitCodeResult, ExecGetExitCodeRequest>(request);
        }
#else
        /// <summary>
        ///  获取exec退出码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExecGetExitCodeResponse> ExecGetExitCode(ExecGetExitCodeRequest request) {
            return await new ExecGetExitCodeExecutor().Client(this).Execute<ExecGetExitCodeResponse, ExecGetExitCodeResult, ExecGetExitCodeRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  创建 exec
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ExecCreateResponse ExecCreate(ExecCreateRequest request) {
            return  new ExecCreateExecutor().Client(this).Execute<ExecCreateResponse, ExecCreateResult, ExecCreateRequest>(request);
        }
#else
        /// <summary>
        ///  创建 exec
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ExecCreateResponse> ExecCreate(ExecCreateRequest request) {
            return await new ExecCreateExecutor().Client(this).Execute<ExecCreateResponse, ExecCreateResult, ExecCreateRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  - 创建pod需要通过实名认证
        /// - hostname规范
        ///     - 支持两种方式：以标签方式书写或以完整主机名方式书写
        ///     - 标签规范
        ///         - 0-9，a-z(不分大小写)和-（减号），其他的都是无效的字符串
        ///         - 不能以减号开始，也不能以减号结尾
        ///         - 最小1个字符，最大63个字符
        ///     - 完整的主机名由一系列标签与点连接组成
        ///         - 标签与标签之间使用“.”(点)进行连接
        ///         - 不能以“.”(点)开始，也不能以“.”(点)结尾
        ///         - 整个主机名（包括标签以及分隔点“.”）最多有63个ASCII字符
        ///     - 正则：&#x60;^([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9-]{0,61}[a-zA-Z0-9])(.([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]))*$&#x60;
        /// - 网络配置
        ///     - 指定主网卡配置信息
        ///         - 必须指定subnetId
        ///         - 可以指定elasticIp规格来约束创建的弹性IP，带宽取值范围[1-100]Mbps，步进1Mbps
        ///         - 可以指定网卡的主IP(primaryIpAddress)和辅助IP(secondaryIpAddresses)，此时maxCount只能为1
        ///         - 可以设置网卡的自动删除autoDelete属性，指明是否删除实例时自动删除网卡
        ///         - 安全组securityGroup需与子网Subnet在同一个私有网络VPC内
        ///         - 一个 pod 创建时必须指定一个安全组，至多指定5个安全组
        ///         - 主网卡deviceIndex设置为1
        /// - 存储
        ///     - volume分为root volume和data volume，root volume的挂载目录是/，data volume的挂载目录可以随意指定
        ///     - volume的底层存储介质当前只支持cloud类别，也就是云硬盘
        ///     - root volume
        ///         - root volume只能是cloud类别
        ///         - 云硬盘类型可以选择ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围[10,100]GB，步长为10G
        ///             - premium-hdd：范围[10,100]GB，步长为10G
        ///         - 自动删除
        ///             - 默认自动删除
        ///         - 可以选择已存在的云硬盘
        ///     - data volume
        ///         - data volume当前只能选择cloud类别
        ///         - 云硬盘类型可以选择ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围[20,1000]GB，步长为10G
        ///             - premium-hdd：范围[20,3000]GB，步长为10G
        ///         - 自动删除
        ///             - 默认自动删除
        ///         - 可以选择已存在的云硬盘
        ///         - 可以从快照创建磁盘
        /// - pod 容器日志
        ///     - default：默认在本地分配10MB的存储空间，自动rotate
        /// - 其他
        ///     - 创建完成后，pod 状态为running
        ///     - maxCount为最大努力，不保证一定能达到maxCount
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreatePodsResponse CreatePods(CreatePodsRequest request) {
            return  new CreatePodsExecutor().Client(this).Execute<CreatePodsResponse, CreatePodsResult, CreatePodsRequest>(request);
        }
#else
        /// <summary>
        ///  - 创建pod需要通过实名认证
        /// - hostname规范
        ///     - 支持两种方式：以标签方式书写或以完整主机名方式书写
        ///     - 标签规范
        ///         - 0-9，a-z(不分大小写)和-（减号），其他的都是无效的字符串
        ///         - 不能以减号开始，也不能以减号结尾
        ///         - 最小1个字符，最大63个字符
        ///     - 完整的主机名由一系列标签与点连接组成
        ///         - 标签与标签之间使用“.”(点)进行连接
        ///         - 不能以“.”(点)开始，也不能以“.”(点)结尾
        ///         - 整个主机名（包括标签以及分隔点“.”）最多有63个ASCII字符
        ///     - 正则：&#x60;^([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9-]{0,61}[a-zA-Z0-9])(.([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9-]{0,61}[a-zA-Z0-9]))*$&#x60;
        /// - 网络配置
        ///     - 指定主网卡配置信息
        ///         - 必须指定subnetId
        ///         - 可以指定elasticIp规格来约束创建的弹性IP，带宽取值范围[1-100]Mbps，步进1Mbps
        ///         - 可以指定网卡的主IP(primaryIpAddress)和辅助IP(secondaryIpAddresses)，此时maxCount只能为1
        ///         - 可以设置网卡的自动删除autoDelete属性，指明是否删除实例时自动删除网卡
        ///         - 安全组securityGroup需与子网Subnet在同一个私有网络VPC内
        ///         - 一个 pod 创建时必须指定一个安全组，至多指定5个安全组
        ///         - 主网卡deviceIndex设置为1
        /// - 存储
        ///     - volume分为root volume和data volume，root volume的挂载目录是/，data volume的挂载目录可以随意指定
        ///     - volume的底层存储介质当前只支持cloud类别，也就是云硬盘
        ///     - root volume
        ///         - root volume只能是cloud类别
        ///         - 云硬盘类型可以选择ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围[10,100]GB，步长为10G
        ///             - premium-hdd：范围[10,100]GB，步长为10G
        ///         - 自动删除
        ///             - 默认自动删除
        ///         - 可以选择已存在的云硬盘
        ///     - data volume
        ///         - data volume当前只能选择cloud类别
        ///         - 云硬盘类型可以选择ssd、premium-hdd
        ///         - 磁盘大小
        ///             - ssd：范围[20,1000]GB，步长为10G
        ///             - premium-hdd：范围[20,3000]GB，步长为10G
        ///         - 自动删除
        ///             - 默认自动删除
        ///         - 可以选择已存在的云硬盘
        ///         - 可以从快照创建磁盘
        /// - pod 容器日志
        ///     - default：默认在本地分配10MB的存储空间，自动rotate
        /// - 其他
        ///     - 创建完成后，pod 状态为running
        ///     - maxCount为最大努力，不保证一定能达到maxCount
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreatePodsResponse> CreatePods(CreatePodsRequest request) {
            return await new CreatePodsExecutor().Client(this).Execute<CreatePodsResponse, CreatePodsResult, CreatePodsRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  停止处于运行状态的单个实例，处于任务执行中的 pod 无法启动。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public StopPodResponse StopPod(StopPodRequest request) {
            return  new StopPodExecutor().Client(this).Execute<StopPodResponse, StopPodResult, StopPodRequest>(request);
        }
#else
        /// <summary>
        ///  停止处于运行状态的单个实例，处于任务执行中的 pod 无法启动。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<StopPodResponse> StopPod(StopPodRequest request) {
            return await new StopPodExecutor().Client(this).Execute<StopPodResponse, StopPodResult, StopPodRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询一个 pod 的详细信息
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribePodResponse DescribePod(DescribePodRequest request) {
            return  new DescribePodExecutor().Client(this).Execute<DescribePodResponse, DescribePodResult, DescribePodRequest>(request);
        }
#else
        /// <summary>
        ///  查询一个 pod 的详细信息
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribePodResponse> DescribePod(DescribePodRequest request) {
            return await new DescribePodExecutor().Client(this).Execute<DescribePodResponse, DescribePodResult, DescribePodRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  获取 pod 中某个容器的详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DecribeContainerResponse DecribeContainer(DecribeContainerRequest request) {
            return  new DecribeContainerExecutor().Client(this).Execute<DecribeContainerResponse, DecribeContainerResult, DecribeContainerRequest>(request);
        }
#else
        /// <summary>
        ///  获取 pod 中某个容器的详情
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DecribeContainerResponse> DecribeContainer(DecribeContainerRequest request) {
            return await new DecribeContainerExecutor().Client(this).Execute<DecribeContainerResponse, DecribeContainerResult, DecribeContainerRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  删除单个 secret
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request) {
            return  new DeleteSecretExecutor().Client(this).Execute<DeleteSecretResponse, DeleteSecretResult, DeleteSecretRequest>(request);
        }
#else
        /// <summary>
        ///  删除单个 secret
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest request) {
            return await new DeleteSecretExecutor().Client(this).Execute<DeleteSecretResponse, DeleteSecretResult, DeleteSecretRequest>(request).ConfigureAwait(false);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  podName 是否符合命名规范，以及查询指定 podName 区域内是否已经存在。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CheckPodNameResponse CheckPodName(CheckPodNameRequest request) {
            return  new CheckPodNameExecutor().Client(this).Execute<CheckPodNameResponse, CheckPodNameResult, CheckPodNameRequest>(request);
        }
#else
        /// <summary>
        ///  podName 是否符合命名规范，以及查询指定 podName 区域内是否已经存在。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CheckPodNameResponse> CheckPodName(CheckPodNameRequest request) {
            return await new CheckPodNameExecutor().Client(this).Execute<CheckPodNameResponse, CheckPodNameResult, CheckPodNameRequest>(request).ConfigureAwait(false);
        }
#endif

            /// <summary>
            ///  默认PodClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>podClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>podClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>podClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造PodClient 对象
                ///</summary>
                PodClient Build();
            }

            /// <summary>
            ///  默认PodClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  PodClient service client
                /// </summary>
                private  PodClient podClient;

                /// <summary>
                ///  默认PodClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    podClient = new PodClient();
                }

                /// <summary>
                ///  构造PodClient 对象
                ///</summary>
                public PodClient Build()
                {
                    if (podClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        podClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (podClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("PodClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (podClient.HttpRequestConfig == null)
                    {
                        podClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (podClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("PodClient build error: http request config not set");
                        }
                    }
                    return podClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>podClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    podClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>podClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    podClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>podClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    podClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
