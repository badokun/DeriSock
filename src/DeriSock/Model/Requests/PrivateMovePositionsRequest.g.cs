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
  public partial class PrivateMovePositionsRequest
  {
    /// <summary>
    /// <para>The currency symbol</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("currency")]
    public CurrencySymbol? Currency { get; set; }
    /// <summary>
    /// <para>Id of source subaccount. Can be found in <c>My Account &gt;&gt; Subaccounts</c> tab</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("source_uid")]
    public long SourceUid { get; set; }
    /// <summary>
    /// <para>Id of target subaccount. Can be found in <c>My Account &gt;&gt; Subaccounts</c> tab</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("target_uid")]
    public long TargetUid { get; set; }
    /// <summary>
    /// <para>List of trades for position move</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("trades")]
    public MovePositionRequestTrade[] Trades { get; set; } = System.Array.Empty<MovePositionRequestTrade>();
  }
}
