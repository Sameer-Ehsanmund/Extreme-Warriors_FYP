using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnlineMenuController : MonoBehaviour
{

    public string versionName = "0.1";

    public InputField creatingGameInput;
    public InputField joiningGameInput;

    //public GameLogic startButton;

    private void Awake()
    {

        PhotonNetwork.ConnectUsingSettings(versionName);
    }

    private void OnConnectedToMaster()
    {

        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    //public void setUserName()
    //{

        //PhotonNetwork.playerName = "tester";
    //}

    public void onCreateGame()
    {

        PhotonNetwork.CreateRoom(creatingGameInput.text, new RoomOptions() { maxPlayers = 2 }, null);
    }

    public void onJoinGame()
    {

        RoomOptions RO = new RoomOptions();
        RO.maxPlayers = 2;
        PhotonNetwork.JoinOrCreateRoom(joiningGameInput.text, RO, TypedLobby.Default);
    }

    private void OnJoinedRoom()
    {

        PhotonNetwork.LoadLevel("Online1");
    }
}
