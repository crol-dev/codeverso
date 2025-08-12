using UnityEngine;

public class ContolaBotoes : MonoBehaviour
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
     public void BtOnClickVoltar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
