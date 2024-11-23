using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingMenuScript : MonoBehaviour
{
    public void BackToMainMenu()
    {
        Debug.Log("Returning to Main Menu...");
        SceneManager.LoadScene("SampleScene"); // กลับไปที่ Main Menu
    }
}
