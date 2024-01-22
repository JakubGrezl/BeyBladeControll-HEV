using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fallen : MonoBehaviour
{
    [SerializeField] 
    private DataHolder.Team WhoWon;

    [SerializeField]
    private TMP_Text text;

    private bool fallenChecked;

    private void Start()
    {
        text.enabled = false;
        fallenChecked = false;
    }

    private void Update()
    {
        if (transform.position.y < -1 && !fallenChecked)
        {
            fallenChecked = true;
            DataHolder.instance.AddWin(WhoWon);
            UIControl.instance.SetWinAnnoucment(WhoWon);
            text.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            fallenChecked = false;
        }
    }
}
