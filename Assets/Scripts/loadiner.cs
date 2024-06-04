using UnityEngine;
using UnityEngine.SceneManagement;

public class loadiner : MonoBehaviour
{
    private float percent = 0f;
    void Update()
    {
        Invoke("percentager", 0.1f);
        if (percent >= 30f) {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
        
    }
    void percentager()
    {
        percent++;
    }
}
