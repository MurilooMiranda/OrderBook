using Core.ExchangeGateway;
using Core.MatchingEngine;

namespace Tests.ChaosTest
{
    public class ChaosTestAsyncSinglePhase : ChaosTestBase
    {
        protected override ExchangeGatewayBase CreateService() => new ExchangeGatewayAsync(new MatchingEngineAsyncSinglePhase());
    }
}
