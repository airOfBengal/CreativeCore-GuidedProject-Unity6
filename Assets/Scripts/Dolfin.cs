using UnityEngine;

public class Dolfin : MonoBehaviour
{
    public ParticleSystem waterSplash;

    public void WaterSplash()
    {
        if (waterSplash != null)
        {
            waterSplash.Play();
        }
    }
}
