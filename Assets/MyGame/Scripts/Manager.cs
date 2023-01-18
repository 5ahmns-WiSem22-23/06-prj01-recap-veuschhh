using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField]
    private float minRange;

    [SerializeField]
    private float maxRange;

    [SerializeField]
    private GameObject present;

    [SerializeField]
    Text presentCountText;

    public static int presentCounter;
  
    float time;
    

    [SerializeField]
    float maxTime;


    [SerializeField]
    Text timeText;



    void Start()
    {
        SpawnTile();
    }

    private void Update()
    {
        presentCountText.text = presentCounter.ToString();
        timeText.text = "Zeit: " + Mathf.Round(maxTime - time).ToString();

        
        time += Time.deltaTime;

        //Neustarten nach Ende der Zeit
        if (time >= maxTime)
        {
            SceneManager.LoadScene(0);
            presentCounter = 0;
            ;
        }

        
       

    }

    public void SpawnTile()
    {
        Instantiate(present, new Vector3(Random.Range(minRange, maxRange), Random.Range(minRange, maxRange), 0), Quaternion.identity);
    }
}
