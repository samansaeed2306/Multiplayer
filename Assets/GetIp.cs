using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using Mirror;
public class GetIp : MonoBehaviour
{
    private NetworkManager networkManager;
    // Start is called before the first frame update
    void Start()
    {
        string externalip = new WebClient().DownloadString("http://ipv4.icanhazip.com/");
        Debug.Log("My Ip is: " + externalip);
        networkManager = GetComponent<NetworkManager>();
        if (networkManager != null)
        {
            // Set the network address to the specified IP address
            networkManager.networkAddress = externalip;
        }
        else
        {
            Debug.LogError("NetworkManager component not found on the GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
