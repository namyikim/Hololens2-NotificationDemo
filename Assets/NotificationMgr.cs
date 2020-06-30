using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NotificationMgr : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject notification1;
    public GameObject notification2;
    public GameObject notification3;
    public GameObject ImageNoti1;
    
    public Boolean b_noti1 = false;
    public Boolean b_noti2 = false;
    public Boolean b_noti3 = false;

    public Boolean b_IMG_noti1 = false;
    public void Start()
    {
        Debug.Log("[namyi] Start()");
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("[namyi] Pressed A key b_noti1 = " + b_noti1);
            
            if (b_noti1==true)
            {
                Debug.Log("[namyi] notification1.SetActive(false); ");
                notification1.SetActive(false);
                b_noti1 = false;
            }
            else
            {
                Debug.Log("[namyi] notification1.SetActive(true); ");
                notification1.SetActive(true);
                b_noti1 = true;
            }         
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("[namyi] Pressed S key");
            
            if (b_noti2 == true)
            {
                notification2.SetActive(false);
                b_noti2 = false;
            }
            else
            {
                notification2.SetActive(true);
                b_noti2 = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("[namyi] Pressed D key");
            
            if (b_noti3 == true)
            {
                notification3.SetActive(false);
                b_noti3 = false;
            }
            else
            {
                notification3.SetActive(true);
                b_noti3 = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("[namyi] Pressed F key");

            if (b_IMG_noti1 == true)
            {
                ImageNoti1.SetActive(false);
                b_IMG_noti1 = false;
            }
            else
            {
                ImageNoti1.SetActive(true);
                b_IMG_noti1 = true;
            }
        }

    }
}

/*
public class NotificationMgr : MonoBehaviour
{

    public bool isAtStartup = true;
    public GameObject cube; 

    NetworkClient myClient;

    public void Start()
    {
        Debug.Log("[namyi] Start()");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("[namyi] Pressed S key");
            SetupServer();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("[namyi] Pressed C key");
            SetupClient();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("[namyi] Pressed B key");
            SetupServer();
            SetupLocalClient();
        }
     
    }

    // Create a server and listen on a port
    public void SetupServer()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.red;

        NetworkServer.Listen(4444);
        isAtStartup = false;
    }

    // Create a client and connect to the server port
    public void SetupClient()
    {
        cube.GetComponent<MeshRenderer>().material.color = Color.yellow;

        myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        myClient.Connect("127.0.0.1", 4444);
        isAtStartup = false;
    }

    // Create a local client and connect to the local server
    public void SetupLocalClient()
    {
        myClient = ClientScene.ConnectLocalServer();
        myClient.RegisterHandler(MsgType.Connect, OnConnected);
        isAtStartup = false;
    }
    // client function
    public void OnConnected(NetworkMessage netMsg)
    {
        
    }

}
*/



