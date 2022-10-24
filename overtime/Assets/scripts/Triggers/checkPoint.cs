using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour, IDataPersistence
{
    [SerializeField] private string id;

    [ContextMenu("Generate guid for id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    private bool saved = false;

    public void LoadData(GameData data)
    {
        data.checkedPoint.TryGetValue(id, out saved);
        if (saved)
        {
            gameObject.SetActive(false);
        }
    }

    public void SaveData(GameData data)
    {
        if (data.checkedPoint.ContainsKey(id))
        {
            data.checkedPoint.Remove(id);
        }
        data.checkedPoint.Add(id, saved);
    }

    private void checkPointChecked()
    {
        saved = true;
        gameObject.SetActive(false);
    }
}
