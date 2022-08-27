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
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
  public partial class CreateSubAccountResponse
  {
    /// <summary>
    /// <para>User email</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("email")]
    public string Email { get; set; } = string.Empty;
    /// <summary>
    /// <para>Subaccount identifier</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("id")]
    public long Id { get; set; }
    /// <summary>
    /// <para><c>true</c> when password for the subaccount has been configured</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("is_password")]
    public bool IsPassword { get; set; }
    /// <summary>
    /// <para>Informs whether login to the subaccount is enabled</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("login_enabled")]
    public bool LoginEnabled { get; set; }
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("portfolio")]
    public SubAccountPortfolio Portfolio { get; set; } = null!;
    /// <summary>
    /// <para>When <c>true</c> - receive all notification emails on the main email</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("receive_notifications")]
    public bool ReceiveNotifications { get; set; }
    /// <summary>
    /// <para>Whether the Security Keys authentication is enabled</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("security_keys_enabled")]
    public bool SecurityKeysEnabled { get; set; }
    /// <summary>
    /// <para>System generated user nickname</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("system_name")]
    public string SystemName { get; set; } = string.Empty;
    /// <summary>
    /// <para>Account type</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("type")]
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// <para>Account name (given by user)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("username")]
    public string Username { get; set; } = string.Empty;
  }
}
