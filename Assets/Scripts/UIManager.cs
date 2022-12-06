using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject play;
    [SerializeField] GameObject lose;
    [SerializeField] GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void plaay()
    {
        Time.timeScale = 1;
        play.SetActive(false);

    }
    public void reload()
    {
        lose.SetActive(false);
        Time.timeScale = 1;
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i);

    }
    public void Go()
    {
        win.SetActive(false);
        Time.timeScale = 1;
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i+1);

    }
}
