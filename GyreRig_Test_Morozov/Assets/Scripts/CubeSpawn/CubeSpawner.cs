using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner: MonoBehaviour
{
    #region Spawn parameters
    [Header("Базовые значения изменяемых параметров")]
    [SerializeField] private float spawnPause;
    [SerializeField] private float spawnVelocity;
    [SerializeField] private float flyingDistance;
    [Header("Зависимости")]
    [SerializeField] UnityEngine.UI.Text spawnPauseText;
    [SerializeField] UnityEngine.UI.Text spawnVelocityText;
    [SerializeField] UnityEngine.UI.Text flyingDistanceText;
    public void UpdateSpawnPause ()
    {
        float value;
        if (!float.TryParse(spawnPauseText.text, out value))
        {
            Debug.LogError("Wrong input for UpdateSpawnPause : "+ spawnPauseText.text);
        }

        if (value > 0)
        {
            spawnPause = value;
        }
    }

    public void UpdateSpawnVelocity()
    {
        float value;
        if (!float.TryParse(spawnVelocityText.text, out value))
        {
            Debug.LogError("Wrong input for UpdateSpawnVelocity : " + spawnVelocityText.text);
        }

        if (value!=0)
        {
            spawnVelocity = value;
        }
    }

    public void UpdateFlyingDistance ()
    {
        float value;
        if (!float.TryParse(flyingDistanceText.text, out value))
        {
            Debug.LogError("Wrong input for UpdateFlyingDistance : " + flyingDistanceText.text);
        }

        if (value>0)
        {
            flyingDistance = value;
        }
    }
    #endregion

    [Header("Постоянные параметры")]
    [SerializeField] Transform spawnPoint;
    [SerializeField] GameObject prefab;

    private void Spawn()
    {
        Instantiate(prefab, spawnPoint.position, Quaternion.identity).
            GetComponent<CubeController>().
            Launch(spawnVelocity, flyingDistance);

        Invoke("Spawn", spawnPause);
    }

    private void Start()
    {
        Spawn();
    }
}
