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
  public partial class PrivateSetMmpConfigRequest
  {
    /// <summary>
    /// <para>The currency symbol</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("currency")]
    public CurrencySymbol Currency { get; set; } = null!;
    /// <summary>
    /// <para>MMP Interval in seconds, if set to 0 MMP is disabled</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("interval")]
    public long Interval { get; set; }
    /// <summary>
    /// <para>MMP frozen time in seconds, if set to 0 manual reset is required</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("frozen_time")]
    public long FrozenTime { get; set; }
    /// <summary>
    /// <para>Quantity limit</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("quantity_limit")]
    public decimal? QuantityLimit { get; set; }
    /// <summary>
    /// <para>Delta limit</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("delta_limit")]
    public decimal? DeltaLimit { get; set; }
  }
}
