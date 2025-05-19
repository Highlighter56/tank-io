using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Scene 1
        if(Input.GetKeyDown("1"))
        {
            SceneManager.LoadScene (sceneName:"Scene1");
        }

        //Scene 2
        if(Input.GetKeyDown("2"))
        {
            SceneManager.LoadScene (sceneName:"Scene2");
        }
    }
}
