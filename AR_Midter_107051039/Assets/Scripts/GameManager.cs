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

}