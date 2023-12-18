using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class PalyerData
{
    public int Coin;
    public int Score;
    public int Round;
    public string Name;

}

public class DataManager : MonoBehaviour
{
    string path;
    string filename = "playerdata";
    public static DataManager instance;
    public PalyerData player = new PalyerData();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
        }
        path = Application.persistentDataPath + "/";
    }
    public void Start()
    {

    }
    public void SavePlayerData()
    {
        string _playerData = JsonUtility.ToJson(player);
        File.WriteAllText(path + filename, _playerData);
    }

    public void LoadPlayerData()
    {
        string _playerData = File.ReadAllText(path + filename);
        player = JsonUtility.FromJson<PalyerData>(_playerData);
    }
}
