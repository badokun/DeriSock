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
  using System;
  using DeriSock.Converter;
  
  /// <summary>
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
  public partial class PrivateGetUserTradesByCurrencyAndTimeRequest
  {
    /// <summary>
    /// <para>The currency symbol</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("currency")]
    public CurrencySymbol Currency { get; set; } = null!;
    /// <summary>
    /// <para>Instrument kind, <c>&quot;combo&quot;</c> for any combo or <c>&quot;any&quot;</c> for all. If not provided instruments of all kinds are considered</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("kind")]
    public InstrumentKind? Kind { get; set; }
    /// <summary>
    /// <para>The earliest timestamp to return result for (milliseconds since the UNIX epoch)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("start_timestamp")]
    [Newtonsoft.Json.JsonConverter(typeof(MillisecondsTimestampConverter))]
    public DateTime StartTimestamp { get; set; }
    /// <summary>
    /// <para>The most recent timestamp to return result for (milliseconds since the UNIX epoch)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("end_timestamp")]
    [Newtonsoft.Json.JsonConverter(typeof(MillisecondsTimestampConverter))]
    public DateTime EndTimestamp { get; set; }
    /// <summary>
    /// <para>Number of requested items, default - <c>10</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("count")]
    public int? Count { get; set; }
    /// <summary>
    /// <para>Include trades older than a few recent days, default - <c>false</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("include_old")]
    public bool? IncludeOld { get; set; }
    /// <summary>
    /// <para>Direction of results sorting (<c>default</c> value means no sorting, results will be returned in order in which they left the database)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("sorting")]
    public UserTradeSortDirection? Sorting { get; set; }
  }
}
