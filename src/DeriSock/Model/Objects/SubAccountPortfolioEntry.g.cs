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
  public partial class SubAccountPortfolioEntry
  {
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("available_funds")]
    public decimal AvailableFunds { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("available_withdrawal_funds")]
    public decimal AvailableWithdrawalFunds { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("balance")]
    public decimal Balance { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("currency")]
    public string Currency { get; set; } = string.Empty;
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("equity")]
    public decimal Equity { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("initial_margin")]
    public decimal InitialMargin { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("maintenance_margin")]
    public decimal MaintenanceMargin { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("margin_balance")]
    public decimal MarginBalance { get; set; }
  }
}
