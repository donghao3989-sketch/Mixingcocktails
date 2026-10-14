using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class onClick : MonoBehaviour
{
    
    //菜单1
    public Button SelectButton11;
    public Button SelectButton12;
    public Button SelectButton13;
    public Button SelectButton14;
    public Button NextButton1;

    public GameObject image11;
    public GameObject image12;
    public GameObject image13;
    public GameObject image14;

    public GameObject menu1;

    //菜单2
    public Button SelectButton21;
    public Button SelectButton22;
    public Button SelectButton23;
    public Button SelectButton24;
    public Button NextButton2;

    public GameObject image21;
    public GameObject image22;
    public GameObject image23;
    public GameObject image24;

    public GameObject menu2;

    //菜单3
    public Button SelectButton31;
    public Button SelectButton32;
    public Button SelectButton33;
    public Button SelectButton34;
    public Button NextButton3;

    public GameObject image31;
    public GameObject image32;
    public GameObject image33;
    public GameObject image34;

    public GameObject menu3;

    //菜单4
    public Button SelectButton41;
    public Button SelectButton42;
    public Button SelectButton43;
    public Button SelectButton44;
    public Button FinishButton;

    public GameObject image41;
    public GameObject image42;
    public GameObject image43;
    public GameObject image44;

    public GameObject menu4;

    public GameObject cup;
    [SerializeField] private Vector2 targetPos = new Vector2(68f, 14f); // 指定坐标
    [SerializeField] private float moveDuration = 0.5f;                // 移动耗时


    private int step1 = 0, step2 = 0, step3 = 0, step4 = 0;//计数


    public int perkcode1;
    public int perkcode2;
    public int perkcode3;

    

    public Sprite[] spriteArray;

    public static bool isDetermined;


    

    public GameObject Missile;

    public GameObject Wave;

    
    


    // Start is called before the first frame update
    void Start()
    {
        
        SelectButton11.onClick.AddListener(TaskonClick11);
        SelectButton12.onClick.AddListener(TaskonClick12);
        SelectButton13.onClick.AddListener(TaskonClick13);
        SelectButton14.onClick.AddListener(TaskonClick14);
        NextButton1.onClick.AddListener(TaskonClick10);

        SelectButton21.onClick.AddListener(TaskonClick21);
        SelectButton22.onClick.AddListener(TaskonClick22);
        SelectButton23.onClick.AddListener(TaskonClick23);
        SelectButton24.onClick.AddListener(TaskonClick24);
        NextButton2.onClick.AddListener(TaskonClick20);

        SelectButton31.onClick.AddListener(TaskonClick31);
        SelectButton32.onClick.AddListener(TaskonClick32);
        SelectButton33.onClick.AddListener(TaskonClick33);
        SelectButton34.onClick.AddListener(TaskonClick34);
        NextButton3.onClick.AddListener(TaskonClick30);

        SelectButton41.onClick.AddListener(TaskonClick41);
        SelectButton42.onClick.AddListener(TaskonClick42);
        SelectButton43.onClick.AddListener(TaskonClick43);
        SelectButton44.onClick.AddListener(TaskonClick44);
        FinishButton.onClick.AddListener(TaskonClick40);

        menu1.SetActive(true);
        menu2.SetActive(false);
        menu3.SetActive(false);
        menu4.SetActive(false);

        //FinishButton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void TaskonClick()
    {
        SceneManager.LoadScene("1");
    }
    void TaskonClick0()
    {
        Debug.Log("0"); ;
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);
        menu4.SetActive(false);
        //NextButton.gameObject.SetActive(true);
        StartCoroutine(MoveToTarget());

    }
    //菜单1点击
    void TaskonClick11()
    {
        Debug.Log("1111"); ;
        image11.SetActive(true);
        image12.SetActive(false);
        image13.SetActive(false);
        image14.SetActive(false);
        NextButton1.gameObject.SetActive(true);
        step1 = 1;
    }

    void TaskonClick12()
    {
        Debug.Log("2222"); ;
        image11.SetActive(false);
        image12.SetActive(true);
        image13.SetActive(false);
        image14.SetActive(false);
        NextButton1.gameObject.SetActive(true);
        step1 = 2;
    }

    void TaskonClick13()
    {
        Debug.Log("3333"); ;
        image11.SetActive(false);
        image12.SetActive(false);
        image13.SetActive(true);
        image14.SetActive(false);
        NextButton1.gameObject.SetActive(true);
        step1 = 3;
    }

    void TaskonClick14()
    {
        Debug.Log("4444"); ;
        image11.SetActive(false);
        image12.SetActive(false);
        image13.SetActive(false);
        image14.SetActive(true);
        NextButton1.gameObject.SetActive(true);
        step1 = 4;
    }

    void TaskonClick10()
    {
        Debug.Log("0"); ;
        menu1.SetActive(false);
        menu2.SetActive(true);
        menu3.SetActive(false);
        menu4.SetActive(false);
        //NextButton.gameObject.SetActive(true);
    }
    //菜单2点击
    void TaskonClick21()
    {
        Debug.Log("1111"); ;
        image21.SetActive(true);
        image22.SetActive(false);
        image23.SetActive(false);
        image24.SetActive(false);
        NextButton2.gameObject.SetActive(true);
        step2 = 1;
    }

    void TaskonClick22()
    {
        Debug.Log("2222"); ;
        image21.SetActive(false);
        image22.SetActive(true);
        image23.SetActive(false);
        image24.SetActive(false);
        NextButton2.gameObject.SetActive(true);
        step2 = 2;
    }

    void TaskonClick23()
    {
        Debug.Log("3333"); ;
        image21.SetActive(false);
        image22.SetActive(false);
        image23.SetActive(true);
        image24.SetActive(false);
        NextButton2.gameObject.SetActive(true);
        step2 = 3;
    }

    void TaskonClick24()
    {
        Debug.Log("4444"); ;
        image21.SetActive(false);
        image22.SetActive(false);
        image23.SetActive(false);
        image24.SetActive(true);
        NextButton2.gameObject.SetActive(true);
        step2 = 4;
    }
    //菜单2下一步
    void TaskonClick20()
    {
        Debug.Log("0"); ;
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(true);
        menu4.SetActive(false);
        //NextButton.gameObject.SetActive(true);
    }
    //菜单3点击
    void TaskonClick31()
    {
        Debug.Log("1111"); ;
        image31.SetActive(true);
        image32.SetActive(false);
        image33.SetActive(false);
        image34.SetActive(false);
        NextButton3.gameObject.SetActive(true);
        step3 = 1;
    }

    void TaskonClick32()
    {
        Debug.Log("2222"); ;
        image31.SetActive(false);
        image32.SetActive(true);
        image33.SetActive(false);
        image34.SetActive(false);
        NextButton3.gameObject.SetActive(true);
        step3 = 2;
    }

    void TaskonClick33()
    {
        Debug.Log("3333"); ;
        image31.SetActive(false);
        image32.SetActive(false);
        image33.SetActive(true);
        image34.SetActive(false);
        NextButton3.gameObject.SetActive(true);
        step3 = 3;
    }

    void TaskonClick34()
    {
        Debug.Log("4444"); ;
        image31.SetActive(false);
        image32.SetActive(false);
        image33.SetActive(false);
        image34.SetActive(true);
        NextButton3.gameObject.SetActive(true);
        step3 = 4;
    }
    //菜单3下一步
    void TaskonClick30()
    {
        Debug.Log("0"); ;
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);
        menu4.SetActive(true);
        //NextButton.gameObject.SetActive(true);
        FinishButton.gameObject.SetActive(false);
    }
    //菜单4点击
    void TaskonClick41()
    {
        Debug.Log("1111"); ;
        image41.SetActive(true);
        image42.SetActive(false);
        image43.SetActive(false);
        image44.SetActive(false);
        FinishButton.gameObject.SetActive(true);
        step4 = 1;
    }

    void TaskonClick42()
    {
        Debug.Log("2222"); ;
        image41.SetActive(false);
        image42.SetActive(true);
        image43.SetActive(false);
        image44.SetActive(false);
        FinishButton.gameObject.SetActive(true);
        step4 = 2;
    }

    void TaskonClick43()
    {
        Debug.Log("3333"); ;
        image41.SetActive(false);
        image42.SetActive(false);
        image43.SetActive(true);
        image44.SetActive(false);
        FinishButton.gameObject.SetActive(true);
        step4 = 3;
    }

    void TaskonClick44()
    {
        Debug.Log("4444"); ;
        image41.SetActive(false);
        image42.SetActive(false);
        image43.SetActive(false);
        image44.SetActive(true);
        FinishButton.gameObject.SetActive(true);
        step4 = 4;
    }
    //菜单4下一步
    void TaskonClick40()
    {
        Debug.Log("0"); ;
        menu1.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(false);
        menu4.SetActive(false);
        //NextButton.gameObject.SetActive(true);
        int result = step1 * 1000 + step2 * 100 + step3 * 10 + step4;
        Debug.Log("当前结果：" + result);
    }
    void TaskonClick1()
    {
        Debug.Log("1111"); ;
        image11.SetActive(true);
        image22.SetActive(false);
        image33.SetActive(false);
        image44.SetActive(false);
        FinishButton.gameObject.SetActive(true);

    }

    void TaskonClick2()
    {
        Debug.Log("2222"); ;
        image11.SetActive(false);
        image22.SetActive(true);
        image33.SetActive(false);
        image44.SetActive(false);
        FinishButton.gameObject.SetActive(true);
    }

    void TaskonClick3()
    {
        Debug.Log("3333"); ;
        image11.SetActive(false);
        image22.SetActive(false);
        image33.SetActive(true);
        image44.SetActive(false);
        FinishButton.gameObject.SetActive(true);
    }

    void TaskonClick4()
    {
        Debug.Log("4444"); ;
        image11.SetActive(false);
        image22.SetActive(false);
        image33.SetActive(false);
        image44.SetActive(true);
        FinishButton.gameObject.SetActive(true);
    }

    private IEnumerator MoveToTarget()
    {
        Vector3 startPos = cup.transform.position;
        Vector3 endPos = new Vector3(targetPos.x, targetPos.y, startPos.z);

        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / moveDuration;
            cup.transform.position = Vector3.Lerp(startPos, endPos, t);
            yield return null;
        }
        cup.transform.position = endPos;
    }
    void Update()
    {
        if (Time.timeScale == 0 && isDetermined == false)
        {
            perkcode1 = Random.Range(1, 11);
            perkcode2 = Random.Range(1, 11);
            perkcode3 = Random.Range(1, 11);
            //perkcode1=3;
            //perkcode2=3;
            //perkcode3=3;
            isDetermined = true;
        }




        if (perkcode1 == 1)
        {
            //perkimage1.sprite = spriteArray[0];
        }

        if (perkcode1 == 2)
        {
            //perkimage1.sprite = spriteArray[1];
        }

        if (perkcode1 == 3)
        {
            //perkimage1.sprite = spriteArray[2];
        }

        if (perkcode1 == 4)
        {
            //perkimage1.sprite = spriteArray[3];
        }

        if (perkcode1 == 5)
        {
            //perkimage1.sprite = spriteArray[4];
        }

        if (perkcode1 == 6)
        {
            //perkimage1.sprite = spriteArray[5];
        }

        if (perkcode1 == 7)
        {
            //perkimage1.sprite = spriteArray[6];
        }

        if (perkcode1 == 8)
        {
            //perkimage1.sprite = spriteArray[7];
        }

        if (perkcode1 == 9)
        {
            //perkimage1.sprite = spriteArray[8];
        }

        if (perkcode1 == 10)
        {
            //perkimage1.sprite = spriteArray[9];
        }

        if (perkcode1 == 11)
        {
            //perkimage3.sprite = spriteArray[10];
        }


        if (perkcode2 == 1)
        {
            //perkimage2.sprite = spriteArray[0];
        }

        if (perkcode2 == 2)
        {
            //perkimage2.sprite = spriteArray[1];
        }

        if (perkcode2 == 3)
        {
            //perkimage2.sprite = spriteArray[2];
        }

        if (perkcode2 == 4)
        {
            //perkimage2.sprite = spriteArray[3];
        }

        if (perkcode2 == 5)
        {
            //perkimage2.sprite = spriteArray[4];
        }

        if (perkcode2 == 6)
        {
            //perkimage2.sprite = spriteArray[5];
        }

        if (perkcode2 == 7)
        {
            //perkimage2.sprite = spriteArray[6];
        }

        if (perkcode2 == 8)
        {
            //perkimage2.sprite = spriteArray[7];
        }

        if (perkcode2 == 9)
        {
            //perkimage2.sprite = spriteArray[8];
        }

        if (perkcode2 == 10)
        {
            //perkimage2.sprite = spriteArray[9];
        }

        if (perkcode2 == 11)
        {
            //perkimage3.sprite = spriteArray[10];
        }


        if (perkcode3 == 1)
        {
            //perkimage3.sprite = spriteArray[0];
        }

        if (perkcode3 == 2)
        {
            //perkimage3.sprite = spriteArray[1];
        }

        if (perkcode3 == 3)
        {
            //perkimage3.sprite = spriteArray[2];
        }

        if (perkcode3 == 4)
        {
            //perkimage3.sprite = spriteArray[3];
        }

        if (perkcode3 == 5)
        {
            //perkimage3.sprite = spriteArray[4];
        }

        if (perkcode3 == 6)
        {
            //perkimage3.sprite = spriteArray[5];
        }

        if (perkcode3 == 7)
        {
            //perkimage3.sprite = spriteArray[6];
        }

        if (perkcode3 == 8)
        {
            //perkimage3.sprite = spriteArray[7];
        }

        if (perkcode3 == 9)
        {
            //perkimage3.sprite = spriteArray[8];
        }

        if (perkcode3 == 10)
        {
            //perkimage3.sprite = spriteArray[9];
        }

        if (perkcode3 == 11)
        {
            //perkimage3.sprite = spriteArray[10];
        }


    }
}
