using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("安德")]
    public Transform Slender;
    [Header("死人骨頭")]
    public Transform Skeleton;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;
    [Header("安德動畫元件")]
    public Animator aniSlender;
    [Header("死人骨頭動畫元件")]
    public Animator aniSkeleton;

    private void Start()
    {
        print("開始事件");
    }

    //public float test = 1;
    //public float test2 = 1;

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        Slender.Rotate(0, joystick.Horizontal * turn, 0);
        Skeleton.Rotate(0, joystick.Horizontal * turn, 0);

        Slender.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        Slender.localScale = new Vector3(1, 1, 1)  * Mathf.Clamp(Slender.localScale.x, 0.5f, 3.5f);
       Skeleton.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        Skeleton.localScale = new Vector3(1, 1, 1)  * Mathf.Clamp(Skeleton.localScale.x, 0.5f, 3.5f);

       // test = Mathf.Clamp(test, 0.5f, 9.9f);
        //print(Mathf.Clamp(test2, 0, 10));
    }

    public void Attack()
    {
        print("攻擊");
        aniSkeleton.SetTrigger("攻擊觸發");
        aniSlender.SetTrigger("恐嚇觸發");
    }

    public void Run()
    {
        print("跑步");
        aniSkeleton.SetTrigger("奔跑觸發");
        aniSlender.SetTrigger("跑步觸發");
    }
}