﻿namespace DeriSock.Response
{
  using Newtonsoft.Json;

  public class PositionResponseData
  {
    /// <summary>
    ///   Average price of trades that built this position
    /// </summary>
    [JsonProperty("average_price")]
    public double AveragePrice { get; set; }

    /// <summary>
    ///   Only for options, average price in USD
    /// </summary>
    [JsonProperty("average_price_usd")]
    public double AveragePriceUsd { get; set; }

    /// <summary>
    ///   Delta parameter
    /// </summary>
    [JsonProperty("delta")]
    public double Delta { get; set; }

    /// <summary>
    ///   Direction: <c>buy</c>, <c>sell</c> or <c>zero</c>
    /// </summary>
    [JsonProperty("direction")]
    public string Direction { get; set; }

    /// <summary>
    ///   Only for futures, estimated liquidation price
    /// </summary>
    [JsonProperty("estimated_liquidation_price")]
    public double EstimatedLiquidationPrice { get; set; }

    /// <summary>
    ///   Floating profit or loss
    /// </summary>
    [JsonProperty("floating_profit_loss")]
    public double FloatingProfitLoss { get; set; }

    /// <summary>
    ///   Only for options, floating profit or loss in USD
    /// </summary>
    [JsonProperty("floating_profit_loss_usd")]
    public double FloatingProfitLossUsd { get; set; }

    /// <summary>
    ///   Only for options, Gamma parameter
    /// </summary>
    [JsonProperty("gamma")]
    public double Gamma { get; set; }

    /// <summary>
    ///   Current index price
    /// </summary>
    [JsonProperty("index_price")]
    public double IndexPrice { get; set; }

    /// <summary>
    ///   Initial margin
    /// </summary>
    [JsonProperty("initial_margin")]
    public double InitialMargin { get; set; }

    /// <summary>
    ///   Unique instrument identifier
    /// </summary>
    [JsonProperty("instrument_name")]
    public string InstrumentName { get; set; }

    /// <summary>
    ///   Instrument kind, <c>future</c> or <c>option</c>
    /// </summary>
    [JsonProperty("kind")]
    public string Kind { get; set; }

    /// <summary>
    ///   Current available leverage for future position
    /// </summary>
    [JsonProperty("leverage")]
    public int Leverage { get; set; }

    /// <summary>
    ///   Maintenance margin
    /// </summary>
    [JsonProperty("maintenance_margin")]
    public double MaintenanceMargin { get; set; }

    /// <summary>
    ///   Current mark price for position's instrument
    /// </summary>
    [JsonProperty("mark_price")]
    public double MarkPrice { get; set; }

    /// <summary>
    ///   Open orders margin
    /// </summary>
    [JsonProperty("open_orders_margin")]
    public double OpenOrdersMargin { get; set; }

    /// <summary>
    ///   Realized funding in current session included in session realized profit or loss, only for positions of perpetual
    ///   instruments
    /// </summary>
    [JsonProperty("realized_funding")]
    public double RealizedFunding { get; set; }

    /// <summary>
    ///   Realized profit or loss
    /// </summary>
    [JsonProperty("realized_profit_loss")]
    public double RealizedProfitLoss { get; set; }

    /// <summary>
    ///   Last settlement price for position's instrument, 0 if instrument wasn't settled yet
    /// </summary>
    [JsonProperty("settlement_price")]
    public double SettlementPrice { get; set; }

    /// <summary>
    ///   Position size for futures size in quote currency (e.g. USD), for options size is in base currency (e.g. BTC)
    /// </summary>
    [JsonProperty("size")]
    public double Size { get; set; }

    /// <summary>
    ///   Only for futures, position size in base currency
    /// </summary>
    [JsonProperty("size_currency")]
    public double SizeCurrency { get; set; }

    /// <summary>
    ///   Only for options, Theta parameter
    /// </summary>
    [JsonProperty("theta")]
    public double Theta { get; set; }

    /// <summary>
    ///   Profit or loss from position
    /// </summary>
    [JsonProperty("total_profit_loss")]
    public double TotalProfitLoss { get; set; }

    /// <summary>
    ///   Only for options, Vega parameter
    /// </summary>
    [JsonProperty("vega")]
    public double Vega { get; set; }
  }
}
