using UnityEngine;

public class ChangeObjectColor : MonoBehaviour
{
    [SerializeField] private Color tint = Color.cyan;
    private Material runtimeMaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Color Tint
    {
        get { return tint; }
        set { tint = value; }
    }
    private void Start()
    {
        runtimeMaterial = GetComponent<Renderer>().material;
        runtimeMaterial.color = tint;
    }

    private void OnDestroy()
    {
        if (runtimeMaterial != null)
        {
            Destroy(runtimeMaterial);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
