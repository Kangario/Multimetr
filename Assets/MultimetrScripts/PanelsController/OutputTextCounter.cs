using UnityEngine;
public class OutputTextCounter : MonoBehaviour
{
  public static GameObject outputText;

    public void Awake()
    {
        outputText = gameObject.transform.GetChild(0).gameObject;
    }
}
