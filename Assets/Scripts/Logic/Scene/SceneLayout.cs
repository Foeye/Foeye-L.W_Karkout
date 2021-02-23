using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLayout : MonoBehaviour
{
    public GameObject WallLeft;
    public GameObject WallRight;
    public GameObject WallTop;
    public float BoardWidth;
    
    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        if (Camera.main == null)
            return;

        Vector3 cameraPos = Camera.main.gameObject.transform.position;
        //to screen right
        WallRight.transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, -cameraPos.z));
        WallRight.transform.localScale = new Vector3(BoardWidth, Screen.height / 100, 1);
        //to screen left
        WallLeft.transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, -cameraPos.z));
        WallLeft.transform.localScale = new Vector3(BoardWidth, Screen.height / 100, 1);
        //to screen top
        WallTop.transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height, -cameraPos.z));
        WallTop.transform.localScale = new Vector3(Screen.width / 100, BoardWidth, 1);

    }

    private void Update()
    {
        
    }
}
