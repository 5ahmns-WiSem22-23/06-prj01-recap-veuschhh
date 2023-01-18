using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartSystem : MonoBehaviour
{


    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    void Update()
    {
        if (GameState.instance.Done == 1)
        { heart3.SetActive(false); }

        if (GameState.instance.Done == 2)
        { heart2.SetActive(false);
            heart3.SetActive(false);
        }

        if (GameState.instance.Done == 3)
        { heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);

            SceneManager.LoadScene(3);
        }

        if (Manager.presentCounter>5)
        {
            SceneManager.LoadScene(4);
        }

    }
}
