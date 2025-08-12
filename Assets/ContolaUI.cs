using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ContolaUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtOnClickIniciar()
    {
        SceneManager.LoadScene(1); 
    }
}
