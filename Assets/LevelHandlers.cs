using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandlers : MonoBehaviour
{
    public void goSitePlan()
    {
        SceneManager.LoadScene(1);
    }

    public void goFloorPlan()
    {
        SceneManager.LoadScene(2);
    }

    public void goFirstSection()
    {
        SceneManager.LoadScene(3);
    }

    public void goSecondSection()
    {
        SceneManager.LoadScene(4);
    }

    public void goGroundPlane3D()
    {
        SceneManager.LoadScene(5);
    }

    public void goMidAir3d()
    {
        SceneManager.LoadScene(6);
    }

    public void goMovableChair()
    {
        SceneManager.LoadScene(7);
    }

    public void goBackToHome()
    {
        SceneManager.LoadScene(0);
    }
}
