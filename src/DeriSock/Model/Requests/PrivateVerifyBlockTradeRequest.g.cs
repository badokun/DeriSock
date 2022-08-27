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
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
  public partial class PrivateVerifyBlockTradeRequest
  {
    /// <summary>
    /// <para>Timestamp, shared with other party (milliseconds since the UNIX epoch)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
    [Newtonsoft.Json.JsonConverter(typeof(MillisecondsTimestampConverter))]
    public DateTime Timestamp { get; set; }
    /// <summary>
    /// <para>Nonce, shared with other party</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("nonce")]
    public string Nonce { get; set; } = string.Empty;
    /// <summary>
    /// <para>Describes if user wants to be maker or taker of trades</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("role")]
    public TradeRole Role { get; set; } = null!;
    /// <summary>
    /// <para>List of trades for block trade</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("trades")]
    public BlockTradeRequestTrade[] Trades { get; set; } = System.Array.Empty<BlockTradeRequestTrade>();
    /// <summary>
    /// <para>The currency symbol</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("currency")]
    public CurrencySymbol? Currency { get; set; }
  }
}
