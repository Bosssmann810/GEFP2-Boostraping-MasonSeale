using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    public void Loadlevel1()
    {
        SceneManager.LoadScene(0);
    }

    public void Loadlevel2()
    {
        SceneManager.LoadScene(1);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
