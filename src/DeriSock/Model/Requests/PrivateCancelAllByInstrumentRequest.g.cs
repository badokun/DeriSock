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
  public partial class PrivateCancelAllByInstrumentRequest
  {
    /// <summary>
    /// <para>Instrument name</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("instrument_name")]
    public string InstrumentName { get; set; } = string.Empty;
    /// <summary>
    /// <para>Order type - <c>limit</c>, <c>stop</c>, <c>take</c>, <c>trigger_all</c> or <c>all</c>, default - <c>all</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("type")]
    public CancelOrderType? Type { get; set; }
    /// <summary>
    /// <para>When detailed is set to <c>true</c> output format is changed. See <a href="https://docs.deribit.com/#detailed-response-for-private-cancel_all-and-private-cancel_by_label-methods">description</a>. Default: <c>false</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("detailed")]
    public bool? Detailed { get; set; }
    /// <summary>
    /// <para>When set to <c>true</c> orders in combo instruments affecting given position will also be cancelled. Default: <c>false</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("include_combos")]
    public bool? IncludeCombos { get; set; }
  }
}
