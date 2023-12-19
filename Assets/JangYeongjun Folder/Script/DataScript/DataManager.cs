using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PalyerData
{
    public int Coin = 5000;
    public int Score =0;
    public int Round=1;
    public string PlayerName="kevin";

}

public class DataManager : MonoBehaviour
{
    public string path;
    public static DataManager instance;
    public int nowSlot;
    public PalyerData player = new PalyerData();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        path = Application.persistentDataPath + "/playerdata.json";
    }
    public void Start()
    {
        SavePlayerData();
    }
    public void SavePlayerData()
    {
        string _playerData = JsonUtility.ToJson(player);
        File.WriteAllText(path, _playerData);
    }

    public void LoadPlayerData()
    {
        string _playerData = File.ReadAllText(path);
        player = JsonUtility.FromJson<PalyerData>(_playerData);
    }
    public void DataClear()
    {
        nowSlot = -1;
        player = new PalyerData();
    }
}
