using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCamera;
    public GameObject Followcamera;
    public GameObject GameCanves;

    public GameObject normalCanvas;


    private void  Awake()
    {
        GameCanves.SetActive(true);
        normalCanvas.SetActive(false);
        
    }


    public void SpawnPlayers()

    {
        float randomValue = Random.Range (-1f,1f); 
        PhotonNetwork.Instantiate(Player.name,new Vector3(this.transform.position.x*randomValue,this.transform.position.z),Quaternion.identity,0);
        MainCamera.SetActive(false);
        GameCanves.SetActive(false);
        normalCanvas.SetActive(true);
        Debug.Log("Spawned");
    }



}
