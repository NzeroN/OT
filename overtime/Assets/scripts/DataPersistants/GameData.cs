using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData : MonoBehaviour
{
    public float position;

    public int deathCount;

    public GameData(){
        this.deathCount = 0
        this.position = 0
    }
}
