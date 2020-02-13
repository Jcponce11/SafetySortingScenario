using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Affirmative"))
        {
            SceneManager.LoadScene("nursing_Scenario_01");
        }

        if (other.gameObject.CompareTag("Negative"))
        {

            Application.Quit();
        }
    }
}
