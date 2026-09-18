using Core.ExchangeGateway;
using Core.MatchingEngine;

namespace Tests.ChaosTest
{
    public class ChaosTestAsyncDoublePhase : ChaosTestBase
    {
        protected override ExchangeGatewayBase CreateService() => new ExchangeGatewayAsync(new MatchingEngineAsyncDoublePhase());
    }
}
