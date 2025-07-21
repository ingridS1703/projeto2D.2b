using UnityEngine;
using TMPro;

public class TrocarTestoV1 : MonoBehaviour
{
    public string texto;
    public TextMeshProUGUI textoUI;

    public void TrocarTestoUI()
    {
        textoUI.text = texto;
    }
    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
