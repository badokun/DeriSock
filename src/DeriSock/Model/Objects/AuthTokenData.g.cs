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
  public partial class AuthTokenData
  {
    /// <summary>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("access_token")]
    public string AccessToken { get; set; } = string.Empty;
    /// <summary>
    /// <para>Token lifetime in seconds</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("expires_in")]
    public long ExpiresIn { get; set; }
    /// <summary>
    /// <para>Can be used to request a new token (with a new lifetime)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("refresh_token")]
    public string RefreshToken { get; set; } = string.Empty;
    /// <summary>
    /// <para>Type of the access for assigned token</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("scope")]
    public string Scope { get; set; } = string.Empty;
    /// <summary>
    /// <para>Optional Session id</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("sid")]
    public string? Sid { get; set; }
    /// <summary>
    /// <para>Copied from the input (if applicable)</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("state")]
    public string? State { get; set; }
    /// <summary>
    /// <para>Authorization type, allowed value - <c>bearer</c></para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("token_type")]
    public string TokenType { get; set; } = string.Empty;
  }
}
