using UnityEngine;

namespace XRMultiplayer
{
    /// <summary>
    /// Allows basic modification of a mesh at runtime.
    /// Arrow keys scale the object; Q/E rotate.
    /// </summary>
    public class SimpleMeshEditor : MonoBehaviour
    {
        void Update()
        {
            float scaleStep = 0.1f;
            if (Input.GetKey(KeyCode.UpArrow))
                transform.localScale += Vector3.up * scaleStep * Time.deltaTime;
            if (Input.GetKey(KeyCode.DownArrow))
                transform.localScale -= Vector3.up * scaleStep * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.up, -30f * Time.deltaTime);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.up, 30f * Time.deltaTime);
        }
    }
}
