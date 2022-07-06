using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool IsActive => gameObject.activeSelf;

    public void Activate()
    {
        gameObject.SetActive(true);
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }

    private void OnBecameInvisible()
    {
        Deactivate();
    }
}
