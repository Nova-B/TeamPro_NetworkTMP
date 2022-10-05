using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text _roomName;

    public void OnClick_CreateRoom()
    {
        if (!PhotonNetwork.IsConnected)
            return;
        //CreateRoom
        //JoinOrCreateRoom
        Debug.Log(_roomName.text);
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, new RoomOptions { MaxPlayers = 6 }, TypedLobby.Default);
        //PhotonNetwork.LoadLevel("WatingRoom");

    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Created room succesfully", this);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room creation Failed " + message, this);

    }
}
