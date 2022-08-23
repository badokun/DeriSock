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
  public partial class UserKindCurrencyChangesChannel : DeriSock.Request.ISubscriptionChannel
  {
    /// <summary>
    /// <para>Instrument kind, <c>&quot;combo&quot;</c> for any combo or <c>&quot;any&quot;</c> for all</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("kind")]
    public InstrumentKind Kind { get; set; } = null!;
    /// <summary>
    /// <para>The currency symbol or <c>&quot;any&quot;</c> for all</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("currency")]
    public CurrencySymbolOrAny Currency { get; set; } = null!;
    /// <summary>
    /// <para>Frequency of notifications. Events will be aggregated over this interval. The value <c>raw</c> means no aggregation will be applied</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("interval")]
    public NotificationInterval2 Interval { get; set; } = null!;
    public string ToChannelName()
    {
      return $"user.changes.{Kind}.{Currency}.{Interval}";
    }
  }
}
