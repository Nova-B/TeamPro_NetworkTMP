using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class RoomListingMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform content;
    [SerializeField]
    private RoomListing roomListing;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        Debug.Log("Listing");

        foreach (RoomInfo info in roomList)
        {
            if(info.MaxPlayers == 0 || info.PlayerCount == 0)
            {
                continue;
            }
            RoomListing listing = (RoomListing)Instantiate(roomListing, content);
            if (listing != null)
            {
                listing.SetRoomInfo(info);
            }
        }
    }
}
