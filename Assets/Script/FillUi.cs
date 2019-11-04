using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FillUi : MonoBehaviour
{

    //DOW UI Elements
    public Text DOWNetChange;
    public Text DOWPercentChange;
    public Text DOWTradePrice;
    public Image DOWArrow;
    public Button DOWButton;

    //NASDAQ UI Elements
    public Text NasdaqNetChange;
    public Text NasdaqPercentChange;
    public Text NasdaqTradePrice;
    public Image NasdaqArrow;
    public Button nasdaqButton;

    //SP500 UI elements
    public Text SP500NetChange;
    public Text SP500PercentChange;
    public Text SP500TradePrice;
    public Image SP500Arrow;
    public Button SP500Button;

    //Public link to FetchData for event trigerring
    public FetchData Data;

    //Stock Panel Elements
    public Text StockName;
    public Text StockSymbol;
    public Text StockTradePrice;
    public Text StockNetChange;
    public Text StockPercentChange;
    public Image StockArrow; 

    //UI Panel 
    public GameObject PanelStock;

    private string MarketCode;
    private string PreviousMarketCode;

    void Start()
    {
        StartCoroutine(Data.Fetch());
    }

    public void FillTheUI()
    {

        foreach (var security in Data.root)
        {
            switch (security.MARKET_CODE)
            {
                case "DJI":

                    DOWNetChange.text = security.NET_CHANGE;
                    //UI color Change
                    if (security.NET_CHANGE.Contains("+"))
                    {
                        DOWNetChange.color = new Color32(4, 209, 103, 255);
                        DOWArrow.enabled = true;
                        DOWArrow.color = new Color32(0, 255, 27, 255);
                        DOWArrow.transform.rotation = Quaternion.Euler(0, 0, 0);

                    }
                    else if (security.NET_CHANGE.Contains("-"))
                    {
                        DOWNetChange.color = new Color32(255, 51, 58, 255);
                        DOWArrow.enabled = true;
                        DOWArrow.color = new Color32(255, 25, 19, 255);
                        DOWArrow.transform.rotation = Quaternion.Euler(0, 0, 180f);
                    }
                    else
                    {
                        DOWNetChange.color = new Color32(255, 255, 255, 255);
                        DOWArrow.enabled = false;
                    }


                    DOWPercentChange.text = "(" + security.PERCENT_CHANGE + "%)";
                    //UI color Change
                    if (security.PERCENT_CHANGE.Contains("+"))
                    {
                        DOWPercentChange.color = new Color32(4, 209, 103, 255);
                    }
                    else if (security.NET_CHANGE.Contains("-"))
                    {
                        DOWPercentChange.color = new Color32(255, 51, 58, 255);
                    }
                    else
                    {
                        DOWPercentChange.color = new Color32(255, 255, 255, 255);
                    }


                    DOWTradePrice.text = security.TRADE_PRICE;

                    //Fill UI Stock Panel
                    if(/*PanelStock.activeSelf == true && */MarketCode == security.MARKET_CODE)
                    {
                        StockName.text = security.SHORT_NAME;
                        StockSymbol.text = "("+ security.SYMBOL+")";
                        StockTradePrice.text = DOWTradePrice.text;
                        StockNetChange.text = DOWNetChange.text;
                        StockPercentChange.text = DOWPercentChange.text;
                        StockArrow.color = DOWArrow.color;
                        StockArrow.transform.rotation = DOWArrow.transform.rotation;
                    }
                    break;

                case "SNP":
                    SP500NetChange.text = security.NET_CHANGE;
                    //UI color Change
                    if (security.NET_CHANGE.Contains("+"))
                    {
                        SP500NetChange.color = new Color32(4, 209, 103, 255);
                        SP500Arrow.enabled = true;
                        SP500Arrow.color = new Color32(0, 255, 27, 255);
                        SP500Arrow.transform.rotation = Quaternion.Euler(0, 0, 0);
                    }
                    else if (security.NET_CHANGE.Contains("-"))
                    {
                        SP500NetChange.color = new Color32(255, 51, 58, 255);
                        SP500Arrow.enabled = true;
                        SP500Arrow.color = new Color32(255, 25, 19, 255);
                        SP500Arrow.transform.rotation = Quaternion.Euler(0, 0, 180f);
                    }
                    else
                    {
                        SP500NetChange.color = new Color32(255, 255, 255, 255);
                        SP500Arrow.enabled = false;
                    }


                    SP500PercentChange.text = "(" + security.PERCENT_CHANGE + "%)";
                    //UI color Change
                    if (security.PERCENT_CHANGE.Contains("+"))
                    {
                        SP500PercentChange.color = new Color32(4, 209, 103, 255);
                    }
                    else if (security.NET_CHANGE.Contains("-"))
                    {
                        SP500PercentChange.color = new Color32(255, 51, 58, 255);
                    }
                    else
                    {
                        SP500PercentChange.color = new Color32(255, 255, 255, 255);
                    }


                    SP500TradePrice.text = security.TRADE_PRICE;

                    //Fill UI Stock Panel
                    if (/*PanelStock.activeSelf == true &&*/ MarketCode == security.MARKET_CODE)
                    {
                        StockName.text = security.SHORT_NAME;
                        StockSymbol.text = "(" + security.SYMBOL + ")";
                        StockTradePrice.text = SP500TradePrice.text;
                        StockNetChange.text = SP500NetChange.text;
                        StockPercentChange.text = SP500PercentChange.text;
                        StockArrow.color = SP500Arrow.color;
                        StockArrow.transform.rotation = SP500Arrow.transform.rotation;
                    }
                    break;

                case "NIM":
                    NasdaqNetChange.text = security.NET_CHANGE;
                    //UI color Change
                    if (security.NET_CHANGE.Contains("+"))
                    {
                        NasdaqNetChange.color = new Color32(4, 209, 103, 255);
                        NasdaqArrow.enabled = true;
                        NasdaqArrow.color = new Color32(0, 255, 27, 255);
                        NasdaqArrow.transform.rotation = Quaternion.Euler(0, 0, 0);
                        
                    }
                    else if (security.NET_CHANGE.Contains("-"))
                    {
                        NasdaqNetChange.color = new Color32(255, 51, 58, 255);
                        NasdaqArrow.enabled = true;
                        NasdaqArrow.color = new Color32(255, 25, 19, 255);
                        NasdaqArrow.transform.rotation = Quaternion.Euler(0, 0, 180f);
                    }
                    else
                    {
                        NasdaqNetChange.color = new Color32(255, 255, 255, 255);
                        NasdaqArrow.enabled = false;
                    }


                    NasdaqPercentChange.text = "(" + security.PERCENT_CHANGE + "%)";
                    //UI color Change
                    if (security.PERCENT_CHANGE.Contains("+"))
                    {
                        NasdaqPercentChange.color = new Color32(4, 209, 103, 255);
                    }
                    else if (security.NET_CHANGE.Contains("-"))
                    {
                        NasdaqPercentChange.color = new Color32(255, 51, 58, 255);
                    }
                    else
                    {
                        NasdaqPercentChange.color = new Color32(255, 255, 255, 255);
                    }


                    NasdaqTradePrice.text = security.TRADE_PRICE;

                    //Fill UI Stock Panel
                    if (/*PanelStock.activeSelf == true && */MarketCode == security.MARKET_CODE)
                    {
                        StockName.text = security.SHORT_NAME;
                        StockSymbol.text = "(" + security.SYMBOL + ")";
                        StockTradePrice.text = NasdaqTradePrice.text;
                        StockNetChange.text = NasdaqNetChange.text;
                        StockPercentChange.text = NasdaqPercentChange.text;
                        StockArrow.color = NasdaqArrow.color;
                        StockArrow.transform.rotation = NasdaqArrow.transform.rotation;
                    }
                    break;

                default:
                    Debug.Log("error");
                    break;
            }

        }
        //Wait half a sec and Start fetch again (refresh data)
        StartCoroutine(WaitHalfSec());

    }

    IEnumerator WaitHalfSec()
    {
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(Data.Fetch());
    }

    //Activate Stock Panel when clicking on Box icon or Deactivate it when clicking twice
    public void ActivateStockPAnel(string MARKET_CODE)
    {
        if(MarketCode == MARKET_CODE)
        {
            PanelStock.SetActive(false);
            MarketCode = null;
        }
        else
        {
            PanelStock.SetActive(false);
            PanelStock.SetActive(true);
            MarketCode = MARKET_CODE;
        }
        
    }

}
