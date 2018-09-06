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
 * cr
 * 容器镜像仓库服务
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Cr.Apis;
using JDCloudSDK.Cr.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Cr.Client
{
    /// <summary>
    ///  cr
    ///  容器镜像仓库服务
    ///  Cr Api 客户端
    ///</summary>
    public class CrClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private CrClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public CrClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public CrClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public CrClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.6
        ///</summary>
        public const string ClientVersion = "1.0.6";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "openapi.cr.jdcloud.com";
        private const string serviceName = "cr";
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
        ///  &lt;p&gt;申请12小时有效期的令牌。 使用&lt;code&gt;docker&lt;/code&gt; CLI push和pull镜像。&lt;/p&gt;
        /// &lt;p&gt;&lt;code&gt;authorizationToken&lt;/code&gt;为每个registry返回一个base64编码的字符串，解码后&lt;code&gt;docker login&lt;/code&gt;命令
        /// 可完成指定registry的鉴权。JCR CLI提供&lt;code&gt;jcr get-login&lt;/code&gt;进行认证处理。&lt;/p&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request) {
            return  new GetAuthorizationTokenExecutor().Client(this).Execute<GetAuthorizationTokenResponse, GetAuthorizationTokenResult, GetAuthorizationTokenRequest>(request);
        }
#else
        /// <summary>
        ///  &lt;p&gt;申请12小时有效期的令牌。 使用&lt;code&gt;docker&lt;/code&gt; CLI push和pull镜像。&lt;/p&gt;
        /// &lt;p&gt;&lt;code&gt;authorizationToken&lt;/code&gt;为每个registry返回一个base64编码的字符串，解码后&lt;code&gt;docker login&lt;/code&gt;命令
        /// 可完成指定registry的鉴权。JCR CLI提供&lt;code&gt;jcr get-login&lt;/code&gt;进行认证处理。&lt;/p&gt;
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GetAuthorizationTokenResponse> GetAuthorizationToken(GetAuthorizationTokenRequest request) {
            return await new GetAuthorizationTokenExecutor().Client(this).Execute<GetAuthorizationTokenResponse, GetAuthorizationTokenResult, GetAuthorizationTokenRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  返回指定repository中images的元数据，包括image size, image tags和creation date。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request) {
            return  new DescribeImagesExecutor().Client(this).Execute<DescribeImagesResponse, DescribeImagesResult, DescribeImagesRequest>(request);
        }
#else
        /// <summary>
        ///  返回指定repository中images的元数据，包括image size, image tags和creation date。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeImagesResponse> DescribeImages(DescribeImagesRequest request) {
            return await new DescribeImagesExecutor().Client(this).Execute<DescribeImagesResponse, DescribeImagesResult, DescribeImagesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过参数创建注册表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateRegistryResponse CreateRegistry(CreateRegistryRequest request) {
            return  new CreateRegistryExecutor().Client(this).Execute<CreateRegistryResponse, CreateRegistryResult, CreateRegistryRequest>(request);
        }
#else
        /// <summary>
        ///  通过参数创建注册表。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateRegistryResponse> CreateRegistry(CreateRegistryRequest request) {
            return await new CreateRegistryExecutor().Client(this).Execute<CreateRegistryResponse, CreateRegistryResult, CreateRegistryRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  查询配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeQuotasResponse DescribeQuotas(DescribeQuotasRequest request) {
            return  new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request);
        }
#else
        /// <summary>
        ///  查询配额
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeQuotasResponse> DescribeQuotas(DescribeQuotasRequest request) {
            return await new DescribeQuotasExecutor().Client(this).Execute<DescribeQuotasResponse, DescribeQuotasResult, DescribeQuotasRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        ///  通过参数创建镜像仓库。
        /// 仓库名称可以分解为多个路径名，每个名称必须至少包含一个小写字母数字，考虑URL规范。
        /// 支持包含段划线或者下划线进行分割，但不允许点&#39;.&#39;，多个路径名之间通过(&quot;/&quot;)连接，总长度不超过256个字符，当前只支持二级目录。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request) {
            return  new CreateRepositoryExecutor().Client(this).Execute<CreateRepositoryResponse, CreateRepositoryResult, CreateRepositoryRequest>(request);
        }
#else
        /// <summary>
        ///  通过参数创建镜像仓库。
        /// 仓库名称可以分解为多个路径名，每个名称必须至少包含一个小写字母数字，考虑URL规范。
        /// 支持包含段划线或者下划线进行分割，但不允许点&#39;.&#39;，多个路径名之间通过(&quot;/&quot;)连接，总长度不超过256个字符，当前只支持二级目录。
        /// 
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateRepositoryResponse> CreateRepository(CreateRepositoryRequest request) {
            return await new CreateRepositoryExecutor().Client(this).Execute<CreateRepositoryResponse, CreateRepositoryResult, CreateRepositoryRequest>(request);
        }
#endif

            /// <summary>
            ///  默认CrClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>crClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>crClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>crClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造CrClient 对象
                ///</summary>
                CrClient Build();
            }

            /// <summary>
            ///  默认CrClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                ///  CrClient service client
                /// </summary>
                private  CrClient crClient;

                /// <summary>
                ///  默认CrClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    crClient = new CrClient();
                }

                /// <summary>
                ///  构造CrClient 对象
                ///</summary>
                public CrClient Build()
                {
                    if (crClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        crClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (crClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("CrClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (crClient.HttpRequestConfig == null)
                    {
                        crClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (crClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("CrClient build error: http request config not set");
                        }
                    }
                    return crClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>crClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    crClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>crClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    crClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>crClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    crClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}
