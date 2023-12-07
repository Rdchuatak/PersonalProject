using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Properties;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager _GMinstance;
    private GameObject spawnPoint;
    
    public int sceneNum;
    public int sceneCount = 1;

    public Vector3 newSpawn;

    //Awake for gameManager
    void Awake()
    {
        //sets up the singleton for the gameManager
        if(_GMinstance == null)
        {
            _GMinstance = this;
            
        }
        
        else if (_GMinstance != this)
        {
            Destroy(gameObject);
            
        }


    }

    // Update is called once per frame
    void Start()
    {
       
    }

    //random scene function. Random Range calls upon numbers 1-3, trust me this can be expanded upon, but I chose 3 to make things simpler. Can be simplified to make SceneManager.LoadScene(sceneNum) if processed correctly)
    //VERY useful to think about if you have it like this. Let's say you want to give this specific scene a stat boost or a special effect due to the scene's attributes, you can place these in these if statements. 
    public void randScene()
    {
       
        
        
        //Debug.Log("I am triggered!");
        int sceneNum = Random.Range(1, 4);
        if(sceneCount < 10)
        {
            Debug.Log(sceneCount);
            if(sceneNum == 1)
            {
                
                
                //Debug.Log("I work");
                sceneCount = sceneCount++;
                SceneManager.LoadScene(1);
                
              
            }
            if (sceneNum == 2)
            {
                //Debug.Log("I work");
                sceneCount = sceneCount++;
                SceneManager.LoadScene(2);
                
                
            }
            if (sceneNum == 3)
            {
                sceneCount = sceneCount++;
                SceneManager.LoadScene(3);
                
                
            }

            return;
        }
        if(sceneCount == 10)
        {
            Debug.Log("Shop Room Before Boss");
        }
        

        //Issue for spawn points, unsure what was wrong.
        // newSpawn = spawnPoint.transform.position;
        
    }
}
