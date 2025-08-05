using UnityEngine;
using UnityEngine.UI;

public class ControleDeAudio : MonoBehaviour
{
    public int Volume;
    public int VolumeSFX;
    public bool musica;
    
    
    public Slider volumeSlider;
    public Slider VolumeSFXSlider;
    public Toggle toggleMusica;
    
    void Start()
    {
        musica = toggleMusica.isOn;
    }


    void Update()
    {
        
    }
}
