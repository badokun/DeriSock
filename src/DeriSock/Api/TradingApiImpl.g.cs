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
namespace DeriSock
{
  using System;
  using System.Threading;
  using System.Threading.Tasks;
  using DeriSock.Api;
  using DeriSock.Net.JsonRpc;
  using DeriSock.Model;
  using Newtonsoft.Json.Linq;
  
  public partial class DeribitClient
  {
    [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
    private sealed partial class TradingApiImpl : ITradingApi
    {
      private readonly DeribitClient _client;
      public TradingApiImpl(DeribitClient client)
      {
        _client = client;
      }
      /// <inheritdoc cref="ITradingApi.PrivateBuy" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrderTrades>> ITradingApi.PrivateBuy(UserOrderRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateBuy(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateSell" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrderTrades>> ITradingApi.PrivateSell(UserOrderRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateSell(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateEdit" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrderTrades>> ITradingApi.PrivateEdit(PrivateEditRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateEdit(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateEditByLabel" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrderTrades>> ITradingApi.PrivateEditByLabel(PrivateEditByLabelRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateEditByLabel(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateCancel" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrder>> ITradingApi.PrivateCancel(UserOrderIdRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateCancel(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateCancelAll" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<decimal>> ITradingApi.PrivateCancelAll(PrivateCancelAllRequest? args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateCancelAll(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateCancelAllByCurrency" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<decimal>> ITradingApi.PrivateCancelAllByCurrency(PrivateCancelAllByCurrencyRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateCancelAllByCurrency(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateCancelAllByInstrument" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<decimal>> ITradingApi.PrivateCancelAllByInstrument(PrivateCancelAllByInstrumentRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateCancelAllByInstrument(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateCancelByLabel" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<decimal>> ITradingApi.PrivateCancelByLabel(PrivateCancelByLabelRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateCancelByLabel(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateClosePosition" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrderTrades>> ITradingApi.PrivateClosePosition(PrivateClosePositionRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateClosePosition(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetMargins" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<InstrumentMargin>> ITradingApi.PrivateGetMargins(PrivateGetMarginsRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetMargins(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetMmpConfig" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<MmpConfig>> ITradingApi.PrivateGetMmpConfig(PrivateGetMmpConfigRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetMmpConfig(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetOpenOrdersByCurrency" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrder[]>> ITradingApi.PrivateGetOpenOrdersByCurrency(PrivateGetOpenOrdersByCurrencyRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetOpenOrdersByCurrency(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetOpenOrdersByInstrument" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrder[]>> ITradingApi.PrivateGetOpenOrdersByInstrument(PrivateGetOpenOrdersByInstrumentRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetOpenOrdersByInstrument(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetOrderHistoryByCurrency" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrder[]>> ITradingApi.PrivateGetOrderHistoryByCurrency(PrivateGetOrderHistoryByCurrencyRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetOrderHistoryByCurrency(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetOrderHistoryByInstrument" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrder[]>> ITradingApi.PrivateGetOrderHistoryByInstrument(PrivateGetOrderHistoryByInstrumentRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetOrderHistoryByInstrument(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetOrderMarginByIds" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<OrderInitialMargin[]>> ITradingApi.PrivateGetOrderMarginByIds(PrivateGetOrderMarginByIdsRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetOrderMarginByIds(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetOrderState" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserOrder>> ITradingApi.PrivateGetOrderState(UserOrderIdRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetOrderState(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetTriggerOrderHistory" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<TriggerOrderHistoryPage>> ITradingApi.PrivateGetTriggerOrderHistory(PrivateGetTriggerOrderHistoryRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetTriggerOrderHistory(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetUserTradesByCurrency" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserTrades>> ITradingApi.PrivateGetUserTradesByCurrency(PrivateGetUserTradesByCurrencyRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetUserTradesByCurrency(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetUserTradesByCurrencyAndTime" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserTrades>> ITradingApi.PrivateGetUserTradesByCurrencyAndTime(PrivateGetUserTradesByCurrencyAndTimeRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetUserTradesByCurrencyAndTime(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetUserTradesByInstrument" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserTrades>> ITradingApi.PrivateGetUserTradesByInstrument(PrivateGetUserTradesByInstrumentRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetUserTradesByInstrument(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetUserTradesByInstrumentAndTime" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserTrades>> ITradingApi.PrivateGetUserTradesByInstrumentAndTime(PrivateGetUserTradesByInstrumentAndTimeRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetUserTradesByInstrumentAndTime(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetUserTradesByOrder" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<UserTrade[]>> ITradingApi.PrivateGetUserTradesByOrder(PrivateGetUserTradesByOrderRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetUserTradesByOrder(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateResetMmp" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<string>> ITradingApi.PrivateResetMmp(PrivateResetMmpRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateResetMmp(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateSendRfq" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<string>> ITradingApi.PrivateSendRfq(PrivateSendRfqRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateSendRfq(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateSetMmpConfig" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<string>> ITradingApi.PrivateSetMmpConfig(PrivateSetMmpConfigRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateSetMmpConfig(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetSettlementHistoryByInstrument" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<SettlementPage>> ITradingApi.PrivateGetSettlementHistoryByInstrument(PrivateGetSettlementHistoryByInstrumentRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetSettlementHistoryByInstrument(args, cancellationToken);
      }
      /// <inheritdoc cref="ITradingApi.PrivateGetSettlementHistoryByCurrency" />
      [System.CodeDom.Compiler.GeneratedCodeAttribute("DeriSock.DevTools", "2.0.0")]
      System.Threading.Tasks.Task<DeriSock.Net.JsonRpc.JsonRpcResponse<SettlementPage>> ITradingApi.PrivateGetSettlementHistoryByCurrency(PrivateGetSettlementHistoryByCurrencyRequest args, CancellationToken cancellationToken)
      {
        return _client.InternalPrivateGetSettlementHistoryByCurrency(args, cancellationToken);
      }
    }
  }
}
