using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2_click : MonoBehaviour
{


    public Button mButton;

    // Use this for initialization
    void Start()
    {
        //获取按钮1
        Button btn = mButton.GetComponent<Button>();
        //给按钮1绑定监听器，点击时执行TaskOnClick方法
        btn.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        //加载场景1
        Application.LoadLevel(2);
    }
}
