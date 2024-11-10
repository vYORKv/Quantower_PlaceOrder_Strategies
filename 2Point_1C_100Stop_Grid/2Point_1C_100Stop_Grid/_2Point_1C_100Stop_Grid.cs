// Copyright QUANTOWER LLC. © 2017-2023. All rights reserved.

using System;
using System.Collections.Generic;
using TradingPlatform.BusinessLayer;
using TradingPlatform.BusinessLayer.Modules;

namespace _2Point_1C_100Stop_Grid
{
    /// <summary>
    /// Information about API you can find here: http://api.quantower.com
    /// Code samples: https://github.com/Quantower/Examples 
    /// </summary>
    public class _2Point_1C_100Stop_Grid : OrderPlacingStrategy
    {
        [InputParameter]
        public int Quantity = 1;
        [InputParameter]
        public int StopLoss = 100;
        public _2Point_1C_100Stop_Grid()
            : base()
        {
            // Defines strategy's name and description.
            this.Name = "2Point_1C_100Stop_Grid";
            this.Description = "My OrderPlacingStrategy's annotation";
        }

        protected override void OnPlaceOrder(PlaceOrderRequestParameters placeOrderRequest)
        {

            // Check whether buying or selling, then execute orders
            if (placeOrderRequest.Side == Side.Buy)
            {
                // Place 1st Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 2nd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 2,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 3rd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 4,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 4th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 6,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 5th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 8,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 6th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 10,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 7th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 12,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 8th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 14,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 9th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 16,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });
                /*
                // Place 10th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 18,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 11th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 20,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 12th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 22,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 13th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 24,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 14th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 26,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 15th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 28,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 16th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 30,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 17th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 32,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 18th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 34,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 19th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 36,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 20th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 38,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });
                
                // Place 21st Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 40,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 22nd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 42,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 23rd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 44,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 24th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 46,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 25th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 48,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 26th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 50,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 27th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 52,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 28th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 54,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 29th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 56,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 30th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price - 58,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });
                */
            }
            else
            {
                // Place 1st Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 2nd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    //Place order code
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 2,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 3rd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 4,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 4th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 6,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 5th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 8,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 6th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 10,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 7th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 12,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 8th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 14,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 9th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 16,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 10th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 18,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });
                /*
                // Place 11th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 20,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 12th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 22,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 13th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 24,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 14th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 26,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 15th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 28,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 16th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 30,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 17th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 32,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 18th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 34,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 19th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 36,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });
                
                // Place 20th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 38,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 21st Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 40,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 22nd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 42,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 23rd Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 44,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 24th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 46,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 25th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 48,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 26th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 50,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 27th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 52,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 28th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 54,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 29th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 56,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });

                // Place 30th Grid Order
                Core.Instance.PlaceOrder(new PlaceOrderRequestParameters()
                {
                    Account = placeOrderRequest.Account,
                    Symbol = placeOrderRequest.Symbol,
                    Side = placeOrderRequest.Side,
                    Price = placeOrderRequest.Price + 58,
                    Quantity = Quantity,
                    StopLoss = SlTpHolder.CreateSL(StopLoss, PriceMeasurement.Offset),
                    OrderTypeId = OrderType.Limit
                });
                */
            }

            //throw new NotImplementedException();
        }

        protected override void OnCancel()
        {
            throw new NotImplementedException();
        }
    }
}