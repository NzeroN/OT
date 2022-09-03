using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistantManager : MonoBehaviour
{
    private GameData = gameData;
    // Start is called before the first frame update
    public static DataPersistantManager instance (get; private set;)

    private void Awake() {
        if (instance != null)
        {
            Debug.LogError("Not found");
        }
    }
    instance = this;

    public void Start(){
        LoadGame();
    }

    public void NewGame(){
        this.gameData = new GameData();
    }

    public void LoadGame(){
        if (this.gameData == null)
        {
            NewGame();
        }
    }

    public void SaveGame(){

    }

    public void OnApplicationExit(){
        SaveGame();
    }
}
