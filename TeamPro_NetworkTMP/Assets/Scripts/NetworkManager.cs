using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    public Text nickNameInput;

    string version = "0.0.0";
    private void Awake()
    {
        Screen.SetResolution(960, 540, false);
        DontDestroyOnLoad(gameObject);
    }

    public void Connect()
    {
        PhotonNetwork.GameVersion = "aasdf";
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.LocalPlayer.NickName = nickNameInput.text;
        print("Connected to Photon.");
        Debug.Log(PhotonNetwork.GameVersion);
        Debug.Log(PhotonNetwork.LocalPlayer.NickName);
        if (!PhotonNetwork.InLobby)
        {
            PhotonNetwork.JoinLobby();
        }
        SceneManager.LoadScene(1);
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Failed to connect to Photon " + cause.ToString(), this);
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
    }
}
