using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReseter : MonoBehaviour
{
    [SerializeField]
    public GameObject playerOne;

    public Vector3 playerOnePos;

    [SerializeField]
    public GameObject playerTwo;

    public Vector3 playerTwoPos;

    private void Awake()
    { 
        playerOnePos = playerOne.transform.position;
        playerTwoPos = playerTwo.transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerOne.transform.position = playerOnePos;
            playerTwo.transform.position = playerTwoPos;
            UIControl.instance.SetWinAnnoucment(false);
        }
    }
}
