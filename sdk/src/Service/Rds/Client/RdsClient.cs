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
 * 云数据库RDS
 * 目前RDS OpenAPI支持云数据库SQL Server，可以通过OpenAPI实现数据库管理，账号管理，备份管理，单库上云等功能，后续将支持云数据库MySQL
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using JDCloudSDK.Core.Auth;
using JDCloudSDK.Core.Client;
using JDCloudSDK.Core.Http;
using JDCloudSDK.Rds.Apis;
using JDCloudSDK.Rds.Model;
using System;
using System.Collections.Generic;
using System.Text;
#if NET40||NET35
#else
using System.Threading.Tasks;
#endif

namespace JDCloudSDK.Rds.Client
{
    /// <summary>
    /// 云数据库RDS
    /// 目前RDS OpenAPI支持云数据库SQL Server，可以通过OpenAPI实现数据库管理，账号管理，备份管理，单库上云等功能，后续将支持云数据库MySQL
    /// Rds Api 客户端
    ///</summary>
    public class RdsClient : JdcloudClient
    {

        /// <summary>
        ///  默认私有构造函数
        /// </summary>
        private RdsClient()
        {

        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        /// <param name="httpRequestConfig">http 客户端配置信息</param>
        /// <param name="environment">sdk 环境配置信息</param>
        public RdsClient(CredentialsProvider credentialsProvider, HttpRequestConfig httpRequestConfig,SDKEnvironment environment)
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
        public RdsClient(CredentialsProvider credentialsProvider,HttpRequestConfig httpRequestConfig)
        {
            this.httpRequestConfig = httpRequestConfig;
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        /// 默认构造函数，
        /// 注意如果使用此方法 httpRequestConfig 使用的http 请求 schema 为Https
        /// </summary>
        /// <param name="credentialsProvider">认证信息</param>
        public RdsClient(CredentialsProvider credentialsProvider)
        {
            this.credentialsProvider = credentialsProvider;
        }

        /// <summary>
        ///  版本号 1.0.1
        ///</summary>
        public const string ClientVersion = "1.0.1";

        private const string apiVersion = "v1";
        private const string userAgentPrefix = "JdcloudSdkDotNet";
        private const string defaultEndpoint = "rds.jdcloud-api.com";
        private const string serviceName = "rds";
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
        /// 创建数据库账户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateAccountResponse CreateAccount(CreateAccountRequest request) {
            return  new CreateAccountExecutor().Client(this).Execute<CreateAccountResponse, CreateAccountResult, CreateAccountRequest>(request);
        }
#else
        /// <summary>
        /// 创建数据库账户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateAccountResponse> CreateAccount(CreateAccountRequest request) {
            return await new CreateAccountExecutor().Client(this).Execute<CreateAccountResponse, CreateAccountResult, CreateAccountRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 数据库账号授权
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public GrantPrivilegeResponse GrantPrivilege(GrantPrivilegeRequest request) {
            return  new GrantPrivilegeExecutor().Client(this).Execute<GrantPrivilegeResponse, GrantPrivilegeResult, GrantPrivilegeRequest>(request);
        }
#else
        /// <summary>
        /// 数据库账号授权
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<GrantPrivilegeResponse> GrantPrivilege(GrantPrivilegeRequest request) {
            return await new GrantPrivilegeExecutor().Client(this).Execute<GrantPrivilegeResponse, GrantPrivilegeResult, GrantPrivilegeRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request) {
            return  new CreateDatabaseExecutor().Client(this).Execute<CreateDatabaseResponse, CreateDatabaseResult, CreateDatabaseRequest>(request);
        }
#else
        /// <summary>
        /// 创建数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateDatabaseResponse> CreateDatabase(CreateDatabaseRequest request) {
            return await new CreateDatabaseExecutor().Client(this).Execute<CreateDatabaseResponse, CreateDatabaseResult, CreateDatabaseRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 获取单库上云文件列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeImportFilesResponse DescribeImportFiles(DescribeImportFilesRequest request) {
            return  new DescribeImportFilesExecutor().Client(this).Execute<DescribeImportFilesResponse, DescribeImportFilesResult, DescribeImportFilesRequest>(request);
        }
#else
        /// <summary>
        /// 获取单库上云文件列表
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeImportFilesResponse> DescribeImportFiles(DescribeImportFilesRequest request) {
            return await new DescribeImportFilesExecutor().Client(this).Execute<DescribeImportFilesResponse, DescribeImportFilesResult, DescribeImportFilesRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 创建备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public CreateBackupResponse CreateBackup(CreateBackupRequest request) {
            return  new CreateBackupExecutor().Client(this).Execute<CreateBackupResponse, CreateBackupResult, CreateBackupRequest>(request);
        }
#else
        /// <summary>
        /// 创建备份
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<CreateBackupResponse> CreateBackup(CreateBackupRequest request) {
            return await new CreateBackupExecutor().Client(this).Execute<CreateBackupResponse, CreateBackupResult, CreateBackupRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 获取备份信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupsResponse DescribeBackups(DescribeBackupsRequest request) {
            return  new DescribeBackupsExecutor().Client(this).Execute<DescribeBackupsResponse, DescribeBackupsResult, DescribeBackupsRequest>(request);
        }
#else
        /// <summary>
        /// 获取备份信息
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupsResponse> DescribeBackups(DescribeBackupsRequest request) {
            return await new DescribeBackupsExecutor().Client(this).Execute<DescribeBackupsResponse, DescribeBackupsResult, DescribeBackupsRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 从用户上传的备份文件中恢复SQL Server数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestoreDatabaseFromFileResponse RestoreDatabaseFromFile(RestoreDatabaseFromFileRequest request) {
            return  new RestoreDatabaseFromFileExecutor().Client(this).Execute<RestoreDatabaseFromFileResponse, RestoreDatabaseFromFileResult, RestoreDatabaseFromFileRequest>(request);
        }
#else
        /// <summary>
        /// 从用户上传的备份文件中恢复SQL Server数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestoreDatabaseFromFileResponse> RestoreDatabaseFromFile(RestoreDatabaseFromFileRequest request) {
            return await new RestoreDatabaseFromFileExecutor().Client(this).Execute<RestoreDatabaseFromFileResponse, RestoreDatabaseFromFileResult, RestoreDatabaseFromFileRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request) {
            return  new DeleteDatabaseExecutor().Client(this).Execute<DeleteDatabaseResponse, DeleteDatabaseResult, DeleteDatabaseRequest>(request);
        }
#else
        /// <summary>
        /// 删除数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteDatabaseResponse> DeleteDatabase(DeleteDatabaseRequest request) {
            return await new DeleteDatabaseExecutor().Client(this).Execute<DeleteDatabaseResponse, DeleteDatabaseResult, DeleteDatabaseRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 数据库账号重置密码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public ResetPasswordResponse ResetPassword(ResetPasswordRequest request) {
            return  new ResetPasswordExecutor().Client(this).Execute<ResetPasswordResponse, ResetPasswordResult, ResetPasswordRequest>(request);
        }
#else
        /// <summary>
        /// 数据库账号重置密码
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequest request) {
            return await new ResetPasswordExecutor().Client(this).Execute<ResetPasswordResponse, ResetPasswordResult, ResetPasswordRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 删除数据库账户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request) {
            return  new DeleteAccountExecutor().Client(this).Execute<DeleteAccountResponse, DeleteAccountResult, DeleteAccountRequest>(request);
        }
#else
        /// <summary>
        /// 删除数据库账户
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DeleteAccountResponse> DeleteAccount(DeleteAccountRequest request) {
            return await new DeleteAccountExecutor().Client(this).Execute<DeleteAccountResponse, DeleteAccountResult, DeleteAccountRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 从云数据库SQL Server备份中恢复单个数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public RestoreDatabaseFromBackupResponse RestoreDatabaseFromBackup(RestoreDatabaseFromBackupRequest request) {
            return  new RestoreDatabaseFromBackupExecutor().Client(this).Execute<RestoreDatabaseFromBackupResponse, RestoreDatabaseFromBackupResult, RestoreDatabaseFromBackupRequest>(request);
        }
#else
        /// <summary>
        /// 从云数据库SQL Server备份中恢复单个数据库
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<RestoreDatabaseFromBackupResponse> RestoreDatabaseFromBackup(RestoreDatabaseFromBackupRequest request) {
            return await new RestoreDatabaseFromBackupExecutor().Client(this).Execute<RestoreDatabaseFromBackupResponse, RestoreDatabaseFromBackupResult, RestoreDatabaseFromBackupRequest>(request);
        }
#endif
#if NET40||NET35
        /// <summary>
        /// 获取备份下载链接
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public DescribeBackupDownloadURLResponse DescribeBackupDownloadURL(DescribeBackupDownloadURLRequest request) {
            return  new DescribeBackupDownloadURLExecutor().Client(this).Execute<DescribeBackupDownloadURLResponse, DescribeBackupDownloadURLResult, DescribeBackupDownloadURLRequest>(request);
        }
#else
        /// <summary>
        /// 获取备份下载链接
        /// </summary>
        /// <param name="request">请求参数信息</param>
        /// <returns>请求结果信息</returns>
        public async Task<DescribeBackupDownloadURLResponse> DescribeBackupDownloadURL(DescribeBackupDownloadURLRequest request) {
            return await new DescribeBackupDownloadURLExecutor().Client(this).Execute<DescribeBackupDownloadURLResponse, DescribeBackupDownloadURLResult, DescribeBackupDownloadURLRequest>(request);
        }
#endif

            /// <summary>
            ///  默认RdsClient 构造器 接口
            ///</summary>
            public interface Builder
            {

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>rdsClient 构造器</returns>
                Builder CredentialsProvider(CredentialsProvider provider);

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>rdsClient 构造器</returns>
                Builder Environment(Core.Client.SDKEnvironment environment);

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>rdsClient 构造器</returns>
                Builder HttpRequestConfig(HttpRequestConfig config);

                /// <summary>
                ///  构造RdsClient 对象
                ///</summary>
                RdsClient Build();
            }

            /// <summary>
            ///  默认RdsClient 构造器
            ///</summary>
            public class DefaultBuilder : Builder
            {
                /// <summary>
                /// RdsClient service client
                /// </summary>
                private  RdsClient rdsClient;

                /// <summary>
                ///  默认RdsClient 构造器构造对象
                ///</summary>
                public DefaultBuilder()
                {
                    rdsClient = new RdsClient();
                }

                /// <summary>
                ///  构造RdsClient 对象
                ///</summary>
                public RdsClient Build()
                {
                    if (rdsClient.CredentialsProvider == null)
                    {
                        //if credentialsProvider not set, try load jdcloud global default  credentials provider
                        rdsClient.credentialsProvider = JdCloud.DefaultInstance.GetCredentialsProvider();
                        if (rdsClient.credentialsProvider == null)
                        {
                            throw new ArgumentNullException("RdsClient build error: jdcloud credentials provider not set");
                        }
                    }
                    if (rdsClient.HttpRequestConfig == null)
                    {
                        rdsClient.httpRequestConfig = JdCloud.DefaultInstance.GetHttpRequestConfig();
                        if (rdsClient.httpRequestConfig == null)
                        {
                        throw new ArgumentNullException("RdsClient build error: http request config not set");
                        }
                    }
                    return rdsClient;
                }

                /// <summary>
                /// 设置认证信息参数
                /// </summary>
                /// <param name="provider">认证信息提供对象</param>
                /// <returns>rdsClient 构造器</returns>
                public Builder CredentialsProvider(CredentialsProvider provider)
                {
                    rdsClient.credentialsProvider = provider;
                    return this;
                }

                /// <summary>
                /// 设置请求环境参数
                /// </summary>
                /// <param name="environment">环境参数信息</param>
                /// <returns>rdsClient 构造器</returns>
                public Builder Environment(SDKEnvironment environment)
                {
                    rdsClient.environment = environment;
                    return this;
                }

                /// <summary>
                /// http 请求配置信息
                /// </summary>
                /// <param name="config">http 请求配置信息</param>
                /// <returns>rdsClient 构造器</returns>
                public Builder HttpRequestConfig(HttpRequestConfig config)
                {
                    rdsClient.httpRequestConfig = config;
                    return this;
                }
            }
    }
}