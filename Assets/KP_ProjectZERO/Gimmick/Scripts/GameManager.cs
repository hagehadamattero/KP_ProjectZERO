using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] const int ROOM_LEFT = 1;
    [SerializeField] const int ROOM_FRONT = 2;
    [SerializeField] const int ROOM_RIGHT = 3;
    [SerializeField] GameObject panelRooms;
    int  roomNumber;

    [SerializeField] GameObject rightButton;
    [SerializeField] GameObject leftButton;

    // Start is called before the first frame update
    void Start()
    {
        roomNumber = ROOM_FRONT;//開始時は真ん中の部屋を向いている
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButtonRight()
    {
        roomNumber++;
        leftButton.SetActive(true);
        if (roomNumber == ROOM_RIGHT)//3
        {
            rightButton.SetActive(false);
        }
        DisplayRoom();
    }

    public void PushButtonLeft()
    {
        roomNumber--;
        rightButton.SetActive(true);
        if (roomNumber == ROOM_LEFT)//1
        {
            leftButton.SetActive(false);
        }
        DisplayRoom();
    }

    void DisplayRoom()
    {
        switch (roomNumber)
        {
            case ROOM_LEFT:
                panelRooms.transform.localPosition = new Vector3(1000f, 0f, 0f);
                break;
            case ROOM_FRONT:
                panelRooms.transform.localPosition = new Vector3(0f, 0f, 0f);
                break;
            case ROOM_RIGHT:
                panelRooms.transform.localPosition = new Vector3(-1000f, 0f, 0f);
                break;
        }
    }
}
