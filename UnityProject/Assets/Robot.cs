using UnityEngine;

public class Robot : MonoBehaviour
{
    [Header("對話")]
    public string say = "你好.....";
    public float sayspeed= 1.5f;
    [Header("任務")]
    public bool Compiete=false;
    public int bateryfinish = 5;
    public int batery = 0;
}
