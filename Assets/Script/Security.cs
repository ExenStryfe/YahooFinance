using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/*public enum MarketCode
{
    DJI,
    NIM,
    SNP,
}*/

// Security Class from JSON 
[Serializable]
public class Security
{
#pragma warning disable 649
    [SerializeField] private string SYMBOL;
    [SerializeField] private string SHORT_NAME;
    [SerializeField] private string MARKET_CODE;
    [SerializeField] private string TRADE_PRICE;
    [SerializeField] private string PERCENT_CHANGE;
    [SerializeField] private string NET_CHANGE;

    public string Symbol => SYMBOL;
    public string ShortName => SHORT_NAME;
    public string MarketCode => MARKET_CODE;
    public string TradePrice => TRADE_PRICE;
    public string PercentChange => PERCENT_CHANGE;
    public string NetChange => NET_CHANGE;
}