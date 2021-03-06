﻿using System.Linq;
using CIAPI.DTO;
using CIAPI.IntegrationTests.Streaming;
using CIAPI.Rpc;
using NUnit.Framework;

namespace CIAPI.IntegrationTests.Rpc
{
    [TestFixture]
    public class CfdMarketsFixture : RpcFixtureBase
    {
        [Test]
        public void CanListCFDMarkets()
        {
            var rpcClient = BuildRpcClient();

            AccountInformationResponseDTO accounts = rpcClient.AccountInformation.GetClientAndTradingAccount();

            var response = rpcClient.CFDMarkets.ListCfdMarkets("USD", null, accounts.ClientAccountId, 500, false);

            Assert.Greater(response.Markets.Length, 0,"no markets returned");


            rpcClient.LogOut();
            rpcClient.Dispose();
        }
    }
}