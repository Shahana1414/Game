using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    public void Change_scene(string Level)
    {
        SceneManager.LoadScene(Level);
    }
    public void Change_Add(string Addition)
    {
        SceneManager.LoadScene(Addition);
    }
    public void Change_Subtract(string Subtraction)
    {
        SceneManager.LoadScene(Subtraction);
    }
    public void Change_Multiplication(string Multiplication)
    {
        SceneManager.LoadScene(Multiplication);
    }
    public void Change_Division(string Division)
    {
        SceneManager.LoadScene(Division);
    }
    public void Change_All(string All)
    {
        SceneManager.LoadScene(All);
    }
    public void Back(string Main)
    {
        SceneManager.LoadScene(Main);
    }

}
