using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// A general scene manager for reloading scenes
/// </summary>
public class GameManager : MonoBehaviour
{
    public KeyCode restartKey;

    #region Singleton Pattern
    /*  
     *  The Singleton Pattern is a design pattern used on classes that intend
     *  on only one instance to be instantiated at all times
     */
    public static GameManager instance;
    void Awake()
    {
        // If there is no instance, create one as our singleton
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);    // The instance stays as an object in our scene even after reload
        }
        else
            Destroy(this);                  // Remove any duplicates
    }
    #endregion

    void Update()
    {
        // Restart Key
        if (Input.GetKeyDown(restartKey))
            SceneManager.LoadScene(0);
    }
}
