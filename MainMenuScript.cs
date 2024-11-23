using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // ฟังก์ชันสำหรับปุ่ม Play
    public void PlayGame()
    {
        Debug.Log("Loading Game Scene...");
        SceneManager.LoadScene("GameScene"); // โหลด Scene สำหรับเกม
    }

    // ฟังก์ชันสำหรับปุ่ม Setting
    public void OpenSettings()
    {
        Debug.Log("Loading Setting Scene...");
        SceneManager.LoadScene("SettingScene"); // โหลด Scene การตั้งค่า
    }

    // ฟังก์ชันสำหรับปุ่ม Exit
    public void QuitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit(); // ปิดเกม
    }
}
