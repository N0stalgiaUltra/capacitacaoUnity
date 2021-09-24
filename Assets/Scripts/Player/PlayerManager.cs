using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    /* 
    #region Singleton
    private static GameManager _instance;
    public static GameManager Instance => _instance;

    private void Awake() {
        if(_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    #endregion*/

    private int points;
    //get e set

    public int Points { 
        get => points;
        set => points = value;
    }

    void Update()
    {
        if (points >= 100)
            SceneManager.LoadScene(1);
    }
}
