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
  public partial class Statistics
  {
    /// <summary>
    /// <para>Highest price during 24h</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("high")]
    public decimal High { get; set; }
    /// <summary>
    /// <para>Lowest price during 24h</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("low")]
    public decimal Low { get; set; }
    /// <summary>
    /// <para>24-hour price change expressed as a percentage, <c>null</c> if there weren&apos;t any trades</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("price_change")]
    public decimal PriceChange { get; set; }
    /// <summary>
    /// <para>Volume during last 24h in base currency</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("volume")]
    public decimal Volume { get; set; }
    /// <summary>
    /// <para>Volume in usd (futures only)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("volume_usd")]
    public decimal? VolumeUsd { get; set; }
  }
}
