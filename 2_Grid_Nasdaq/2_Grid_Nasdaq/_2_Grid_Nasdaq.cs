// Copyright QUANTOWER LLC. © 2017-2023. All rights reserved.

using System;
using System.Collections.Generic;
using TradingPlatform.BusinessLayer;
using TradingPlatform.BusinessLayer.Modules;

namespace _2_Grid_Nasdaq
{
    /// <summary>
    /// Information about API you can find here: http://api.quantower.com
    /// Code samples: https://github.com/Quantower/Examples 
    /// </summary>
    public class _2_Grid_Nasdaq : OrderPlacingStrategy
    {
        [InputParameter]
        public int Grid_1_Quantity = 2;
        // or 1 and 4 (not great)
        // or 2 and 6 (best for increasing leverage, next level)
        [InputParameter]
        public int Grid_2_Quantity = 3;
        public _2_Grid_Nasdaq()
            : base()
        {
            // Defines strategy's name and description.
            this.Name = "2_Grid_Nasdaq";
            this.Description = "My OrderPlacingStrategy's annotation";
        }

        protected override void OnPlaceOrder(PlaceOrderRequestParameters placeOrderRequest)
        {
            // Check whether buying or selling, then execute orders
            if (placeOrderRequest.Side == Side.Buy)
            {
                // Place First Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price,
                    Quantity = Grid_1_Quantity,
                    StopLoss = SlTpHolder.CreateSL(32, PriceMeasurement.Offset),
                    //TakeProfit = SlTpHolder.CreateSL(10, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place Second Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 3,
                    Quantity = Grid_2_Quantity,
                    StopLoss = SlTpHolder.CreateSL(20, PriceMeasurement.Offset),
                    //TakeProfit = SlTpHolder.CreateSL(22, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

            }
            else
            {
                // Place First Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price,
                    Quantity = Grid_1_Quantity,
                    StopLoss = SlTpHolder.CreateSL(32, PriceMeasurement.Offset),
                    //TakeProfit = SlTpHolder.CreateSL(10, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place Second Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 3,
                    Quantity = Grid_2_Quantity,
                    StopLoss = SlTpHolder.CreateSL(20, PriceMeasurement.Offset),
                    //TakeProfit = SlTpHolder.CreateSL(22, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

            }
        }

        protected override void OnCancel()
        {
            throw new NotImplementedException();
        }
    }
}