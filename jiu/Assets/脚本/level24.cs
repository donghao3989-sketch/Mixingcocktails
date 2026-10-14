using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class level24 : MonoBehaviour
{
    [Header("基底按钮")]
    public Button button11;   // 在 Inspector 中拖入按钮
    //public Button button12;
    //public Button button13;
    public Button button14;
    //[Header("基底色块")]
    //public GameObject jidi1;
    //public GameObject jidi2;
    //public GameObject jidi3;
    [Header("基底动画")]
    public GameObject ainjidi1;
    //public GameObject ainjidi2;
    //public GameObject ainjidi3;
    [Header("菜单")]
    public GameObject menu1;
    public GameObject menu2;
    private bool isJidi1Open = false;  // 记录 jidi1 当前是否已打开
    private bool isJidi2Open = false;
    private bool isJidi3Open = false;
    private bool isBusy = false;       // 防止协程期间重复点击
    [Header("tip")]
    public GameObject tip;
    //public AudioSource sfxSource; // 常激活物体上的 AudioSource
    //public AudioClip openClip;
    public GameObject cup;
    [SerializeField] private Vector2 targetPos = new Vector2(68f, 14f); // 指定坐标
    [SerializeField] private float moveDuration = 0.5f;                // 移动耗时
    void Start()
    {
        button11.onClick.AddListener(TaskonClick11);
        //button12.onClick.AddListener(TaskonClick12);
        //button13.onClick.AddListener(TaskonClick13);
        button14.onClick.AddListener(TaskonClick14);
        menu1.SetActive(false);
        menu2.SetActive(false);
        tip.SetActive(false);
        button14.gameObject.SetActive(false);
    }
    
    void TaskonClick11()
    {
        
        Debug.Log("1111");
        button14.gameObject.SetActive(true);
        if (isBusy) return;            // 正在处理中，忽略点击
        StartCoroutine(TaskonClick11Routine());
    }
    void TaskonClick12()
    {
        Debug.Log("1111");
        button14.gameObject.SetActive(true);
        if (isBusy) return;            // 正在处理中，忽略点击
        StartCoroutine(TaskonClick12Routine());
    }
    void TaskonClick13()
    {
        Debug.Log("1111");
        button14.gameObject.SetActive(true);
        if (isBusy) return;            // 正在处理中，忽略点击
        StartCoroutine(TaskonClick13Routine());
    }
    void TaskonClick14()
    {
        Debug.Log("1111");
        if (isBusy) return;            // 正在处理中，忽略点击
        StartCoroutine(TaskonClick14Routine());
    }
    
    IEnumerator TaskonClick11Routine()
    {
        isBusy = true;
        button11.interactable = false;  // 禁用按钮
        //button12.interactable = false;
        //button13.interactable = false;
        button14.interactable = false;

        // 再次点击时，jidi1 先关闭
        if (isJidi1Open)
        {
            //jidi1.SetActive(false);
            isJidi1Open = false;
        }
        if (isJidi2Open)
        {
            //jidi2.SetActive(false);
            isJidi2Open = false;
        }
        if (isJidi3Open)
        {
            //jidi3.SetActive(false);
            isJidi3Open = false;
        }
        // 立即打开 ainjidi1
        ainjidi1.SetActive(true);

        //// 播放音效：推荐用常激活的 AudioSource，不会被 ainjidi1 关闭打断
        //if (sfxSource != null && openClip != null)
        //    sfxSource.PlayOneShot(openClip);

        // 等待 2 秒
        yield return new WaitForSeconds(2f);

        // 打开 jidi1
        //jidi1.SetActive(true);
        isJidi1Open = true;

        // ainjidi1 打开 2 秒后关闭
        ainjidi1.SetActive(false);

        // 恢复按钮可点击
        button11.interactable = true;
        //button12.interactable = true;
        //button13.interactable = true;
        button14.interactable = true;
        isBusy = false;
    }
    IEnumerator TaskonClick12Routine()
    {
        isBusy = true;
        button11.interactable = false;  // 禁用按钮
        //button12.interactable = false;
        //button13.interactable = false;
        button14.interactable = false;

        // 再次点击时，jidi1 先关闭
        if (isJidi1Open)
        {
            //jidi1.SetActive(false);
            isJidi1Open = false;
        }
        if (isJidi2Open)
        {
            //jidi2.SetActive(false);
            isJidi2Open = false;
        }
        if (isJidi3Open)
        {
            //jidi3.SetActive(false);
            isJidi3Open = false;
        }
        // 立即打开 ainjidi1
        //ainjidi2.SetActive(true);

        // 等待 2 秒
        yield return new WaitForSeconds(2f);

        // 打开 jidi1
        //jidi2.SetActive(true);
        isJidi2Open = true;

        // ainjidi1 打开 2 秒后关闭
        //ainjidi2.SetActive(false);

        // 恢复按钮可点击
        button11.interactable = true;
        //button12.interactable = true;
        //button13.interactable = true;
        button14.interactable = true;
        isBusy = false;
    }
    IEnumerator TaskonClick13Routine()
    {
        isBusy = true;
        button11.interactable = false;  // 禁用按钮
        //button12.interactable = false;
        //button13.interactable = false;
        button14.interactable = false;

        // 再次点击时，jidi1 先关闭
        if (isJidi1Open)
        {
            //jidi1.SetActive(false);
            isJidi1Open = false;
        }
        if (isJidi2Open)
        {
            //jidi2.SetActive(false);
            isJidi2Open = false;
        }
        if (isJidi3Open)
        {
            //jidi3.SetActive(false);
            isJidi3Open = false;
        }
        // 立即打开 ainjidi1
        //ainjidi3.SetActive(true);

        // 等待 2 秒
        yield return new WaitForSeconds(2f);

        // 打开 jidi1
        //jidi3.SetActive(true);
        isJidi3Open = true;

        // ainjidi1 打开 2 秒后关闭
        //ainjidi3.SetActive(false);

        // 恢复按钮可点击
        button11.interactable = true;
        //button12.interactable = true;
        //button13.interactable = true;
        button14.interactable = true;
        isBusy = false;
    }

    IEnumerator TaskonClick14Routine()
    {
        isBusy = true;
        button11.interactable = false;  // 禁用按钮
        //button12.interactable = false;
        //button13.interactable = false;
        button14.interactable = false;

        if (isJidi1Open == true)
        { 
            menu1.SetActive(false);
            menu2.SetActive(true);
            // 相机沿世界 X 轴移动 2 个单位
            cup.transform.position = new Vector3(-906.58f, -510.2704f, -1539.359f);
        }
        if (isJidi1Open == false)
        {
            tip.SetActive(true);
            yield return new WaitForSeconds(3f);
            tip.SetActive(false);
        }
        //if (sfxSource != null && openClip != null)
        //    sfxSource.PlayOneShot(openClip);

        // 再次点击时，jidi1 先关闭
        //if (isJidi1Open)
        //{
        //    jidi1.SetActive(false);
        //    isJidi1Open = false;
        //}
        //if (isJidi2Open)
        //{
        //    jidi2.SetActive(false);
        //    isJidi2Open = false;
        //}
        //if (isJidi3Open)
        //{
        //    jidi3.SetActive(false);
        //    isJidi3Open = false;
        //}
        //// 立即打开 ainjidi1
        //ainjidi3.SetActive(true);

        // 等待 2 秒
        //yield return new WaitForSeconds(2f);

        //// 打开 jidi1
        //jidi3.SetActive(true);
        //isJidi3Open = true;

        // ainjidi1 打开 2 秒后关闭
        //ainjidi3.SetActive(false);

        // 恢复按钮可点击
        button11.interactable = true;
        //button12.interactable = true;
        //button13.interactable = true;
        button14.interactable = true;
        isBusy = false;
    }
}