using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject gameCanvas;
    public GameObject sceneCamera;

    public void Awake()
    {

        gameCanvas.SetActive(true);
    }

    public void spawnPlayers()
    {

        float randomValue = Random.Range(-1f, 3f);

        PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(this.transform.position.x * randomValue,
            this.transform.position.y, this.transform.position.z), Quaternion.identity, 0);

        gameCanvas.SetActive(false);
        sceneCamera.SetActive(false);
    }
}
