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
  public partial class PrivateDisableCancelOnDisconnectRequest
  {
    /// <summary>
    /// <para>Specifies if Cancel On Disconnect change should be applied/checked for the current connection or the account (default - <c>connection</c>)</para>
    /// <para><b>NOTICE:</b> Scope <c>connection</c> can be used only when working via Websocket.</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("scope")]
    public ConnectionScope? Scope { get; set; }
  }
}
