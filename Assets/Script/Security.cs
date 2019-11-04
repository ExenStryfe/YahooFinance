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
        public string INTERNAL_SYMBOL;
        public string INTERNAL_SYMBOL_UPPERCASE;
        public string SYMBOL;
        public string DATA_PROVIDER_SECURITY_SYMBOL;
        public string GROUP_CODE;
        public string SECURITY_TYPE;
        public string DISPLAY_NAME;
        public string SHORT_NAME;
        public string NAME;
        public string MARKET_CODE;
        public string TRADE_DATE;
        public string TRADE_TIME;
        public string TRADE_PRICE;
        public string TRADE_PRICE_FULL;
        public string TRADE_PRICE_EXT_HOURS;
        public string TRADE_PRICE_FULL_EXT_HOURS;
        public string TRADE_DATE_EXT_HOURS;
        public string TRADE_TIME_EXT_HOURS;
        public string PERCENT_CHANGE;
        public string PERCENT_CHANGE_FULL;
        public string PERCENT_CHANGE_EXT_HOURS;
        public string NET_CHANGE;
        public string NET_CHANGE_FULL;
        public string NET_CHANGE_EXT_HOURS;
        public string NET_CHANGE_ARROW;
        public string NET_CHANGE_ARROW_EXT_HOURS;
        public string VOLUME;
        public string VOLUME_FULL;
        public string OPEN_VALUE;
        public string CLOSE_VALUE;
        public string LOW_VALUE;
        public string HIGH_VALUE;
        public string PRICE_PRECISION;
        public string UNITS;
        public string EXPIRY_DATE;
        public string EXPIRY_MONTH;
        public string EXPIRY_MMMYY;
        public string CLOSE_YIELD;
        public string YIELD;
        public string YIELD_TO_MATURITY;
        public string TURNOVER;
        public string TURNOVER_FULL;
        public string MATURITY_DATE;
        public string TERM_YEARS;
        public string COUPON;
        public string NBR_COUPONS_PER_YEAR;
        public string PREVIOUS_CLOSE;
        public string BID;
        public string ASK;
        public string PE_RATIO;
        public string INDUSTRY;
        public string IPO_PRICE;
        public string IPO_DATE;
        public string DATA_PROVIDER_NAME;
        public string __invalid_name__52WK_HIGH;
        public string __invalid_name__52WK_HIGH_DATE;
        public string __invalid_name__52WK_LOW;
        public string __invalid_name__52WK_LOW_DATE;
        public string __invalid_name__1YR_NET_CHANGE;
        public string __invalid_name__1YR_PERCENTAGE_CHANGE;
        public string YTD_NET_CHANGE;
        public string YTD_PERCENT_CHANGE;
        public string MARKET_STATUS;
        public string MARKET_CAP;
        public string MARKET_CAP_DISPLAY;
        public string NBR_TRADES;
        public string OPEN_INTEREST;
        public string TIMESTAMP_LOCAL;
        public string TIMESTAMP_UTC;
        public string DIVIDEND;
        public string VOLUME_AVG;
        public string EARNINGS_PER_SHARE;
        public string OUTSTANDING_SHARES;
        public string BETA_RATIO;
        public string __invalid_name__1YR_TARGET_ESTIMATE;
        public string NEXT_EARNING_DATE;
        public string CUSTOM_DATA;
        public DateTime FETCHED_TIMESTAMP_UTC;
        public string COUNTRY_CODE;
        public string CURRENCY_CODE;
        public string CURRENCY_SYMBOL;
        public string MARKET_VOLUME;
        public string MARKET_TURNOVER;
        public string MARKET_VOLUME_CODE;
        public string MARKET_TURNOVER_CODE;
    }


