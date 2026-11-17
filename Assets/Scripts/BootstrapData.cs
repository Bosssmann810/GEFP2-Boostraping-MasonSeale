using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public static class PerformBootstrap
{
    const string SceneName = "Bootstraper";

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    public static void Execute()
    {
        for(int sceneIndex = 0; sceneIndex < SceneManager.sceneCount; sceneIndex++ )
        {
            var candidate = SceneManager.GetSceneAt(sceneIndex);

            if (candidate.name == SceneName)
            {
                return;
            }
        }
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);
    }
}
public class BootstrapData : MonoBehaviour
{
    public static BootstrapData Instance { get; private set; }
    public GameObject sceneManager;
    public SceneManagement sceneManagement;
    public GameObject inputManager;
    public PlayerInput inputManagement;

    public GameObject pointlessManager;
    public PointlessManager pointlessManagement; 
    private void Awake()
    {
        if (Instance != null )
        {
            Debug.Log("nope not allowed to have more then one, destroying gameObject");
            Destroy(gameObject);
        }

        Instance = this;
        Debug.Log("New Instance of bootstrapData online");
        if (sceneManager != null)
        {
            sceneManagement = sceneManager.GetComponent<SceneManagement>();
            if (sceneManagement != null)
            {
                Debug.Log("sceneManagement online");
            }
        }
        if( inputManager != null)
        {
            inputManagement = inputManager.GetComponent<PlayerInput>();
            if(inputManagement != null)
            {
                Debug.Log("inputManager online");
            }

        }
        if(pointlessManager != null)
        {
            pointlessManagement = pointlessManager.GetComponent<PointlessManager>();
            if(pointlessManagement != null)
            {
                Debug.Log("pointlessManagement online");
            }
        }
        if ( sceneManagement != null && inputManagement != null && pointlessManagement != null)
        {
            Debug.Log("all set");
        }
        DontDestroyOnLoad(gameObject);

    }

    public void test()
    {

    }
}
