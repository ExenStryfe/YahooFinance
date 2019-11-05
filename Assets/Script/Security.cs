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
        public string SYMBOL;
        public string SHORT_NAME;
        public string NAME;
        public string MARKET_CODE;
        public string TRADE_PRICE;
        public string PERCENT_CHANGE;
        public string NET_CHANGE;
    }


