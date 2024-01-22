using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHolder : MonoBehaviour
{
    public static DataHolder instance;

    public int winsRed;
    public int winsBlue;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void AddWin(Team color)
    {
        if (color == Team.Red)
        {
            winsRed++;
            UIControl.instance.SetScore(winsRed, Team.Red);
        }
        if (color == Team.Blue)
        {
            winsBlue++;
            UIControl.instance.SetScore(winsBlue, Team.Blue);

        }
    }

    public string GetTeam(Team color)
    {
        if (color == Team.Red)
            return "Červenej";
        if (color == Team.Blue)
            return "Modrej";
        return null;
    }

    public enum Team
    {
        Red,
        Blue
    }
}
