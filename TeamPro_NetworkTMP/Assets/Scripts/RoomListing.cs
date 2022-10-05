using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class RoomListing : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Text _text;

    [SerializeField]
    public Text enterPlayer;

    RoomInfo roomInfo;
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        this.roomInfo = roomInfo;
        Debug.Log(roomInfo.Name);
        _text.text = roomInfo.Name;
    }

    public void OnClick_Button()
    {
        PhotonNetwork.JoinRoom(roomInfo.Name);
        Debug.Log("Join");
    }


    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        enterPlayer = GameObject.Find("PlayerText").GetComponent<Text>();
        enterPlayer.text = newPlayer.NickName;
        Debug.Log("Enter");
    }
}
