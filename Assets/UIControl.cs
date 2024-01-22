using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public static UIControl instance;

    [SerializeField]
    private TMP_Text redPanel;

    [SerializeField]
    private TMP_Text bluePanel;

    [SerializeField]
    private TMP_Text winAnnoucment;

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

        bluePanel.text = "0";
        redPanel.text = "0";
    }

    public void SetScore(int score, DataHolder.Team team)
    {
        if (team == DataHolder.Team.Red)
            redPanel.text = score.ToString();
        if (team == DataHolder.Team.Blue)
            bluePanel.text = score.ToString();
    }

    public void SetWinAnnoucment(DataHolder.Team team)
    {
        winAnnoucment.text = "Vyhrál " + DataHolder.instance.GetTeam(team) + " pro reset zmáčkni R";
        winAnnoucment.enabled = true;
    }

    public void SetWinAnnoucment(bool condition)
    {
        winAnnoucment.enabled = condition;
    }
}
