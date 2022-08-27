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
  public partial class PublicGetOrderBookRequest
  {
    /// <summary>
    /// <para>The instrument name for which to retrieve the order book, see <a href="https://docs.deribit.com/#public-get_instruments"><c>public/get_instruments</c></a> to obtain instrument names.</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("instrument_name")]
    public string InstrumentName { get; set; } = string.Empty;
    /// <summary>
    /// <para>The number of entries to return for bids and asks.</para>
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [Newtonsoft.Json.JsonPropertyAttribute("depth")]
    public decimal? Depth { get; set; }
  }
}
