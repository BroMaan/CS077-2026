using UnityEngine;

public class RotateObject : MonoBehaviour
{

    [SerializeField] private float degreesPerSecond = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float DegreesPerSecond
    {
        get { return degreesPerSecond;}
        set {degreesPerSecond = value;}
    }
    private void Start()
    {
        TranslateObject mover = GetComponent<TranslateObject>();
        if (mover != null)
        {
            mover.Speed = 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * DegreesPerSecond * Time.deltaTime, Space.Self);
    }
}
