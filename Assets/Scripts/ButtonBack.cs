using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBack : MonoBehaviour
{


    public Button mButton;

    // Use this for initialization
    void Start()
    {
        //获取回退按钮
        Button btn = mButton.GetComponent<Button>();
        //给回退按钮绑定监听器，点击时执行TaskOnClick方法
        btn.onClick.AddListener(TaskOnClick);
    }


    void TaskOnClick()
    {
        //加载菜单场景
        Application.LoadLevel(0);
    }
}
