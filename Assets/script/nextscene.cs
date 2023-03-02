using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

}