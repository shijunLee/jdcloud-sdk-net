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


namespace JDCloudSDK.Partner.Model
{

    /// <summary>
    ///  orderItemDetail
    /// </summary>
    public class OrderItemDetail
    {

        ///<summary>
        /// 价格快照Json
        ///</summary>
        public string PriceSnapshot{ get; set; }
        ///<summary>
        /// 变更前资源配置
        ///</summary>
        public List<ExtraInfo> ExtraInfoBefore{ get; set; }
        ///<summary>
        /// 变更后资源配置
        ///</summary>
        public List<ExtraInfo> ExtraInfoAfter{ get; set; }
        ///<summary>
        /// 商品规格参数
        ///</summary>
        public List<ExtraInfo> ExtraInfo{ get; set; }
        ///<summary>
        /// 应付金额（元）
        ///</summary>
        public double? ActualFee{ get; set; }
        ///<summary>
        /// 数量
        ///</summary>
        public int? Quantity{ get; set; }
        ///<summary>
        /// 续费前资源到期时间
        ///</summary>
        public string ExpireDateBefore{ get; set; }
        ///<summary>
        /// 续费后资源到期时间
        ///</summary>
        public string ExpireDateAfter{ get; set; }
        ///<summary>
        /// 计费时长单位
        ///</summary>
        public string Unit{ get; set; }
        ///<summary>
        /// 计费时长（购买时长）
        ///</summary>
        public int? ChargeDuration{ get; set; }
        ///<summary>
        /// 计费类型
        ///</summary>
        public string ChargeMode{ get; set; }
        ///<summary>
        /// 订单总额（元）
        ///</summary>
        public double? TotalFee{ get; set; }
        ///<summary>
        /// 资源类型
        ///</summary>
        public string ServiceName{ get; set; }
        ///<summary>
        /// 站点类型 0：主站,1：国际站,2：云市场
        ///</summary>
        public string SiteType{ get; set; }
        ///<summary>
        /// 下单时间
        ///</summary>
        public string CreateTime{ get; set; }
        ///<summary>
        /// 订单商品状态：创建中、成功、失败
        ///</summary>
        public int? Status{ get; set; }
        ///<summary>
        /// 资源id
        ///</summary>
        public string ItemId{ get; set; }
        ///<summary>
        /// 资源名称
        ///</summary>
        public string ItemName{ get; set; }
        ///<summary>
        /// 计算公式（配置细项）
        ///</summary>
        public string Formula{ get; set; }
        ///<summary>
        /// 订单编号
        ///</summary>
        public string OrderNumber{ get; set; }
        ///<summary>
        /// 实际支付总金额
        ///</summary>
        public double? AllActualFee{ get; set; }
        ///<summary>
        /// 备注
        ///</summary>
        public string Remark{ get; set; }
        ///<summary>
        /// 现金支付
        ///</summary>
        public double? MoneyPay{ get; set; }
        ///<summary>
        /// 余额支付
        ///</summary>
        public double? BalancePay{ get; set; }
        ///<summary>
        /// 已退款金额
        ///</summary>
        public double? RefundFee{ get; set; }
        ///<summary>
        /// 订单计费类型：按配置、包年包月、按用量actualFee
        ///</summary>
        public int? ChargeModeInfo{ get; set; }
        ///<summary>
        /// 退款状态 RefundStatusEnum 0,申请退款 1,退款审核中 2,已退款 3,已取消 4,退款失败 5,财务审批驳回 6,财务审批通过
        ///</summary>
        public int? DeleteStatus{ get; set; }
        ///<summary>
        /// 代金券金额
        ///</summary>
        public double? FavorableFee{ get; set; }
        ///<summary>
        /// 变配明细
        ///</summary>
        public int? ResizeFormulaType{ get; set; }
    }
}
