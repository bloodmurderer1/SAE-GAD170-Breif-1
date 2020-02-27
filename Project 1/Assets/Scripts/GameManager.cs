using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;

    public int targetScore = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameManager.score == this.targetScore)
        {
            Debug.Log("Player has collected " + this.targetScore + " coins!");

            this.gameObject.SetActive(false);
        }
    }
}
