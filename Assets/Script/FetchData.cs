using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Events;

public class FetchData : MonoBehaviour
{
    private string url = "http://y.astuce.media:9990/gfx/finance/group.json?GroupCode=StockBoxAuto";
    private string mySavedJSON;
    public RootObject root;

    public UnityEvent dataUpdated;

    //Unity Web Request GET JSON
    public IEnumerator Fetch()
    {
        UnityWebRequest w = UnityWebRequest.Get(url);
        yield return w.SendWebRequest();
        if (w.isNetworkError || w.isHttpError)
            Debug.Log("Network Error" + w.error);
        else
        {
            mySavedJSON = w.downloadHandler.text;
           //Debug.Log(mySavedJSON);
            DataUpdate(mySavedJSON);
            dataUpdated.Invoke();
        }

    }

    // Data creation/overwrite with JSON
    public void DataUpdate(string SavedJSON)
    {
        if (root == null)
            root = JsonUtility.FromJson<RootObject>(SavedJSON);
        else
           JsonUtility.FromJsonOverwrite(SavedJSON, root);
    }  

 
}
