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
  /// <para>Order type, default - <c>all</c></para>
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "0.3.5")]
  public partial class OpenOrderType : DeriSock.Model.EnumValue
  {
    public static OpenOrderType All = new OpenOrderType("all");
    public static OpenOrderType Limit = new OpenOrderType("limit");
    public static OpenOrderType TriggerAll = new OpenOrderType("trigger_all");
    public static OpenOrderType StopAll = new OpenOrderType("stop_all");
    public static OpenOrderType StopLimit = new OpenOrderType("stop_limit");
    public static OpenOrderType StopMarket = new OpenOrderType("stop_market");
    public static OpenOrderType TakeAll = new OpenOrderType("take_all");
    public static OpenOrderType TakeLimit = new OpenOrderType("take_limit");
    public static OpenOrderType TakeMarket = new OpenOrderType("take_market");
    public static OpenOrderType TrailingAll = new OpenOrderType("trailing_all");
    public static OpenOrderType TrailingStop = new OpenOrderType("trailing_stop");
    private OpenOrderType(string value) : 
        base(value)
    {
    }
  }
}
