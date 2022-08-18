// --------------------------------------------------------------------------
// <auto-generated>
//      This code was generated by a tool.
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
// </auto-generated>
// --------------------------------------------------------------------------
#pragma warning disable CS1591
#nullable enable
namespace DeriSock.Model
{
  
  /// <summary>
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
  public partial class PrivateBuyRequest
  {
    /// <summary>
    /// <para>Instrument name</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("instrument_name")]
    public string InstrumentName { get; set; } = string.Empty;
    /// <summary>
    /// <para>It represents the requested order size. For perpetual and futures the amount is in USD units, for options it is amount of corresponding cryptocurrency contracts, e.g., BTC or ETH</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("amount")]
    public decimal Amount { get; set; }
    /// <summary>
    /// <para>The order type, default: <c>&quot;limit&quot;</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("type")]
    public BuySellOrderType? Type { get; set; }
    /// <summary>
    /// <para>user defined label for the order (maximum 64 characters)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("label")]
    public string? Label { get; set; }
    /// <summary>
    /// <para>The order price in base currency (Only for limit and stop_limit orders)</para>
    /// <para>When adding order with advanced=usd, the field price should be the option price value in USD.</para>
    /// <para>When adding order with advanced=implv, the field price should be a value of implied volatility in percentages. For example,  price=100, means implied volatility of 100%</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("price")]
    public decimal? Price { get; set; }
    /// <summary>
    /// <para>Specifies how long the order remains in effect. Default <c>&quot;good_til_cancelled&quot;</c></para>
    /// <para>- <c>&quot;good_til_cancelled&quot;</c> - unfilled order remains in order book until cancelled</para>
    /// <para>- <c>&quot;good_til_day&quot;</c> - unfilled order remains in order book till the end of the trading session</para>
    /// <para>- <c>&quot;fill_or_kill&quot;</c> - execute a transaction immediately and completely or not at all</para>
    /// <para>- <c>&quot;immediate_or_cancel&quot;</c> - execute a transaction immediately, and any portion of the order that cannot be immediately filled is cancelled</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("time_in_force")]
    public TimeInForce? TimeInForce { get; set; }
    /// <summary>
    /// <para>Maximum amount within an order to be shown to other customers, <c>0</c> for invisible order</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("max_show")]
    public decimal? MaxShow { get; set; }
    /// <summary>
    /// <para>If true, the order is considered post-only. If the new price would cause the order to be filled immediately (as taker), the price will be changed to be just below the spread.</para>
    /// <para>Only valid in combination with time_in_force=<c>&quot;good_til_cancelled&quot;</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("post_only")]
    public bool? PostOnly { get; set; }
    /// <summary>
    /// <para>If an order is considered post-only and this field is set to true then the order is put to order book unmodified or request is rejected.</para>
    /// <para>Only valid in combination with <c>&quot;post_only&quot;</c> set to true</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("reject_post_only")]
    public bool? RejectPostOnly { get; set; }
    /// <summary>
    /// <para>If <c>true</c>, the order is considered reduce-only which is intended to only reduce a current position</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("reduce_only")]
    public bool? ReduceOnly { get; set; }
    /// <summary>
    /// <para>Trigger price, required for trigger orders only (Stop-loss or Take-profit orders)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("trigger_price")]
    public decimal? TriggerPrice { get; set; }
    /// <summary>
    /// <para>The maximum deviation from the price peak beyond which the order will be triggered</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("trigger_offset")]
    public decimal? TriggerOffset { get; set; }
    /// <summary>
    /// <para>Defines the trigger type. Required for <c>&quot;Stop-Loss&quot;</c>, <c>&quot;Take-Profit&quot;</c> and <c>&quot;Trailing&quot;</c> trigger orders</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("trigger")]
    public TriggerType? Trigger { get; set; }
    /// <summary>
    /// <para>Advanced option order type. (Only for options)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("advanced")]
    public AdvancedOptionOrderType? Advanced { get; set; }
    /// <summary>
    /// <para>Order MMP flag, only for order_type &apos;limit&apos;</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("mmp")]
    public bool? Mmp { get; set; }
    /// <summary>
    /// <para>Timestamp, when provided server will start processing request in Matching Engine only before given timestamp, in other cases <c>timed_out</c> error will be responded. Remember that the given timestamp should be consistent with the server&apos;s time, use <a href="https://docs.deribit.com/#public-get_time">/public/time</a> method to obtain current server time.</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("valid_until")]
    public int? ValidUntil { get; set; }
  }
}
