using System.Collections;//you can delete it
using System.Collections.Generic;//you can delete it
using UnityEngine;

public class Dog : MonoBehaviour
{
    //藉由加上下面的<#region 欄位區域>來整理程式碼 
    #region 欄位區域 
    //欄位 field (變數)
    // 修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    // private 私人(不顯示) public (公開)
    [Header("跳躍次數")]
    [Range(1, 10)]//設定範圍
    public int jumpCount = 8;
    [Header("跳躍高度")]//能夠在unity看見
    public int jump = 100;
    public float speed = 10.5f;
    [Header("是否在地板上"), Tooltip("檢查腳色是否在地板上")]
    public bool isGround; //預設為取消(False)
    public string dogName = "Kid";

    public Transform dog;
    public Transform cam;

    //初始事件：遊戲開始執行一次
    private void Start()
    {
        print("哈囉");
    }

    //更新事件：每一禎執行一遍
    private void Update()
    {
        MoveDog();
        MoveCamera();
    }

    #endregion
    /// <summary>
    /// 狗移動方法
    /// </summary>
    private void MoveDog()
    {
        dog.Translate(5 * Time.deltaTime, 5 * Time.deltaTime, 0);//狗這個物件有物理性質
    }

    /// <summary>
    /// 攝影機移動方法
    /// </summary>
    private void MoveCamera()
    {
        cam.Translate(5*Time.deltaTime, 0, 0); 
    }

    /// <summary>
    /// 跳躍方法
    /// </summary>
    public void Jump()//方法第一個字母要大寫
    {
        print("跳躍");
    }

    /// <summary>
    /// 滑行方法
    /// </summary>
    public void Slide()//方法第一個字母要大寫
    {
        print("滑行");
    }


    
}
