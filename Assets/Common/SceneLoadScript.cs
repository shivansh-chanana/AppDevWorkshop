using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This is common scene loader script 
/// Currently being used on menu buttons
/// </summary>
public class SceneLoadScript : MonoBehaviour
{
    public string sceneName;

    public void LoadScene() 
    {
        SceneManager.LoadScene(sceneName);
    }
}
