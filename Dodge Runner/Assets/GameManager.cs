using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{



    public Button restartButton;

    public void GameOver()
    {

        restartButton.gameObject.SetActive(true);



    }


    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
    // Start is called before the first frame update
    void Start()
    {
        




    }




    // Update is called once per frame
    void Update()
    {
        




    }
}
