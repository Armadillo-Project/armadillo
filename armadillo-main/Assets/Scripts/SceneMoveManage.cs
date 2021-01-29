using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManage : MonoBehaviour
{

    public void ChangeScene()
    {
        if (CompareTag("SettingsButton"))
        {
            SceneManager.LoadScene("Settings Scene");
        }
        else if (CompareTag("GameStartButton"))
        {
            SceneManager.LoadScene("Game Scene");
        }
        // 버튼에 tag 추가 > CompareTag("버튼 태그 이름") > SceneManager.LoadScene("씬이름"); 사용

    }
}
