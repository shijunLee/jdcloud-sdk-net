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
 * dosage monitoring openapi
 * dosage monitoring openapi
 *
 * OpenAPI spec version: v1
 * Contact: 
 *
 * NOTE: This class is auto generated by the jdcloud code generator program.
 */


using System;
using System.Collections.Generic;
using System.Text;


namespace JDCloudSDK.Ossopenapi.Model
{

    /// <summary>
    ///  bucketMonitorStatisticQueryResult
    /// </summary>
    public class BucketMonitorStatisticQueryResult
    {

        ///<summary>
        /// 查询结果总数
        ///</summary>
        public int? TotalCount{ get; set; }
        ///<summary>
        /// bucket 统计列表
        ///</summary>
        public List<BucketMonitorStatistic> QueryList{ get; set; }
    }
}