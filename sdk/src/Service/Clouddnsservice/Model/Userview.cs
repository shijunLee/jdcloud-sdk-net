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


namespace JDCloudSDK.Clouddnsservice.Model
{

    /// <summary>
    ///  userview
    /// </summary>
    public class Userview
    {

        ///<summary>
        /// 自定义线路ID
        ///</summary>
        public int? ViewId{ get; set; }
        ///<summary>
        /// 自定义线路名称, 最多64个字符
        ///</summary>
        public string ViewName{ get; set; }
        ///<summary>
        /// 主域名ID
        ///</summary>
        public int? DomainId{ get; set; }
        ///<summary>
        /// 域名
        ///</summary>
        public string DomainName{ get; set; }
        ///<summary>
        /// 是否删除，0:没有删除，1:已删除
        ///</summary>
        public int? IsDelete{ get; set; }
        ///<summary>
        /// 创建者
        ///</summary>
        public string Creator{ get; set; }
        ///<summary>
        /// 创建时间，格式Unix timestamp，时间单位：秒
        ///</summary>
        public int? CreateTime{ get; set; }
        ///<summary>
        /// 更新者
        ///</summary>
        public string Updator{ get; set; }
        ///<summary>
        /// 更新时间，格式Unix timestamp，时间单位：秒
        ///</summary>
        public int? UpdateTime{ get; set; }
    }
}
