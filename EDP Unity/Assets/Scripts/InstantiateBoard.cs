using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBoard : MonoBehaviour
{

    public GameObject MainGame;
    public Transform Trigger;
    // Start is called before the first frame update
    void Start()
    {
        
            Instantiate(MainGame, Trigger.position, Trigger.rotation);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
