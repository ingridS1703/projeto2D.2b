using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadscene : MonoBehaviour
{
    public string jogo_PJD2M;

    public void Load()
    {
        SceneManager.LoadScene(jogo_PJD2M);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
