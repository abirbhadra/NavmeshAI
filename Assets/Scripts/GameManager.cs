using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public Transform playerPostition;

    public static GameManager instance { get; private set; }

    private void Awake()
    {
        instance = this;
        // If an instance of this singleton already exists,
        // destroy this duplicate. This ensures only one ever exists.
       /* if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            // Otherwise, set this object as the one and only instance.
            Instance = this;

        }*/
    }
}
