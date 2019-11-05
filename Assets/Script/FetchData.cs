using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Events;

public class FetchData
{
    private readonly string _url;
    private RootObject root;

    public delegate void DataUpdatedHandler(RootObject root);
    public event DataUpdatedHandler DataUpdated;

    public FetchData(string url)
    {
        _url = url;
    }
    //Unity Web Request GET JSON
    public IEnumerator Fetch()
    {
        using (var w = UnityWebRequest.Get(_url))
        {
            yield return w.SendWebRequest();
            if (w.isNetworkError || w.isHttpError)
                Debug.Log("Network Error" + w.error);
            else
            {
                //Debug.Log(mySavedJSON);
                DataUpdate(w.downloadHandler.text);
                DataUpdated?.Invoke(root);
            }
        }
    }

    // Data creation/overwrite with JSON
    private void DataUpdate(string json)
    {
        if (root == null)
            root = JsonUtility.FromJson<RootObject>(json);
        else
           JsonUtility.FromJsonOverwrite(json, root);
    }  

 
}
