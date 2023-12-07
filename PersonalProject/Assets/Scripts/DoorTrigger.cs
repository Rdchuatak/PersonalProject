using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : GameManager
{
    public int enemyCount = 0;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PlayerTag")
        {
            if(enemyCount > 0)
            {
                //Debug.Log("Locked");
                return;
            }
            else if(enemyCount == 0)
            {
                GetComponent<GameManager>().randScene();
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
