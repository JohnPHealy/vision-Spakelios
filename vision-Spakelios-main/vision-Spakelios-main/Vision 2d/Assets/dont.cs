using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dont : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        
        if (scene.name == "end screen") 
        {
            Destroy(this.gameObject);
        }
    }
}
