using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    public PhotonView playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        //try to connect
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        //we connected
        Debug.Log("Connected to master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a room successfully!");
        PhotonNetwork.Instantiate(playerPrefab.name,Vector3.right*3,Quaternion.identity);
    }
}
