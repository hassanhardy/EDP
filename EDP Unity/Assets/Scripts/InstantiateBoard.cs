using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBoard : MonoBehaviour
{

    public GameObject MainGame;
    public Transform Trigger;
    private GameObject MainGameInstance;
    // Start is called before the first frame update
    void Start()
    {
        MainGameInstance = Instantiate(MainGame, Trigger.position, Trigger.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        MainGameInstance.transform.position = Trigger.transform.position;
        MainGameInstance.transform.rotation = Trigger.transform.rotation;
        
    }
}
