using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject cpu, expansion, video, chipset, ram, batteriaCMOS, bios, cpuBlack, porteIo, expansionBlack, videoBlack, chipsetBlack, ramBlack, batteriaCMOSBlack, biosBlack, porteIoBlack;
    
    public TextMeshProUGUI cpuText, expansionText, videoText, chipsetText, ramText, batteriaCMOSText, biosText, porteIoText;
    
    
    public GameObject finalImage;

    public GameObject vinto;

    private CanvasGroup finalImageCanvasGroup;

    private Vector2 cpuInitialPos, expansionInitialPos, videoInitialPos, chipsetInitialPos, ramInitialPos, batteriaCMOSInitialPos, biosInitialPos, porteIoInitialPos;

    public bool cpuLocked, expansionLocked, videoLocked, chipsetLocked, ramLocked, batteriaCMOSLocked, biosLocked, porteIoLocked;

    // Durata della dissolvenza in secondi
    public float fadeDuration = 1.5f;


    public AudioSource source;
    public AudioClip correct;
    public AudioClip incorrect;

    // Start is called before the first frame update
    void Start()
    {
        cpuInitialPos = cpu.transform.position;
        expansionInitialPos = expansion.transform.position;
        videoInitialPos = video.transform.position;
        chipsetInitialPos = chipset.transform.position;
        ramInitialPos = ram.transform.position;
        batteriaCMOSInitialPos = batteriaCMOS.transform.position;
        biosInitialPos = bios.transform.position;
        porteIoInitialPos = porteIo.transform.position;


        cpuLocked = false;
        expansionLocked = false;
        videoLocked = false;
        chipsetLocked = false;
        ramLocked = false;
        batteriaCMOSLocked = false;
        biosLocked = false;
        porteIoLocked = false;

        vinto.SetActive(false);
       

        // Ottieni il CanvasGroup dal finalImage
        finalImageCanvasGroup = finalImage.GetComponent<CanvasGroup>();
        
        if (finalImageCanvasGroup != null)
        {
            finalImageCanvasGroup.alpha = 0; // Inizialmente invisibile
            finalImage.SetActive(false); // Nasconde finalImage
        }
        else
        {
            Debug.LogError("CanvasGroup non trovato su finalImage. Aggiungilo nell'Inspector.");
        }
    }

    public void DragCpu()
    {
        if (!cpuLocked)
        {
            cpu.transform.position = Input.mousePosition;
        }
    }

    public void DropCpu()
    {
        float Distance = Vector3.Distance(cpu.transform.position, cpuBlack.transform.position);
        if (Distance < 50)
        {
            cpuLocked = true;
            cpu.transform.localScale = cpuBlack.transform.localScale;
            cpu.transform.position = cpuBlack.transform.position;
            cpuText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            cpu.transform.position = cpuInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragExpansion()
    {
        if (!expansionLocked)
        {
            expansion.transform.position = Input.mousePosition;
        }
    }

    public void DropExpansion()
    {
        float Distance = Vector3.Distance(expansion.transform.position, expansionBlack.transform.position);
        if (Distance < 50)
        {
            expansionLocked = true;
            expansion.transform.localScale = expansionBlack.transform.localScale;
            expansion.transform.position = expansionBlack.transform.position;
            expansionText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            expansion.transform.position = expansionInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragVideo()
    {
        if (!videoLocked)
        {
            video.transform.position = Input.mousePosition;
        }
    }

    public void DropVideo()
    {
        float Distance = Vector3.Distance(video.transform.position, videoBlack.transform.position);
        if (Distance < 50)
        {
            videoLocked = true;
            video.transform.localScale = videoBlack.transform.localScale;
            video.transform.position = videoBlack.transform.position;
            videoText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            video.transform.position = videoInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragChipset()
    {
        if (!chipsetLocked)
        {
            chipset.transform.position = Input.mousePosition;
        }
    }

    public void DropChipset()
    {
        float Distance = Vector3.Distance(chipset.transform.position, chipsetBlack.transform.position);
        if (Distance < 50)
        {
            chipsetLocked = true;
            chipset.transform.localScale = chipsetBlack.transform.localScale;
            chipset.transform.position = chipsetBlack.transform.position;
            chipsetText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            chipset.transform.position = chipsetInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragRam()
    {
        if (!ramLocked)
        {
            ram.transform.position = Input.mousePosition;
        }
    }

    public void DropRam()
    {
        float Distance = Vector3.Distance(ram.transform.position, ramBlack.transform.position);
        if (Distance < 50)
        {
            ramLocked = true;
            ram.transform.localScale = ramBlack.transform.localScale;
            ram.transform.position = ramBlack.transform.position;
            ramText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            ram.transform.position = ramInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragBatteriaCMOS()
    {
        if (!batteriaCMOSLocked)
        {
            batteriaCMOS.transform.position = Input.mousePosition;
        }
    }

    public void DropBatteriaCMOS()
    {
        float Distance = Vector3.Distance(batteriaCMOS.transform.position, batteriaCMOSBlack.transform.position);
        if (Distance < 50)
        {
            batteriaCMOSLocked = true;
            batteriaCMOS.transform.localScale = batteriaCMOSBlack.transform.localScale;
            batteriaCMOS.transform.position = batteriaCMOSBlack.transform.position;
            batteriaCMOSText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            batteriaCMOS.transform.position = batteriaCMOSInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragBios()
    {
        if (!biosLocked)
        {
            bios.transform.position = Input.mousePosition;
        }
    }

    public void DropBios()
    {
        float Distance = Vector3.Distance(bios.transform.position, biosBlack.transform.position);
        if (Distance < 50)
        {
            biosLocked = true;
            bios.transform.localScale = biosBlack.transform.localScale;
            bios.transform.position = biosBlack.transform.position;
            biosText.color = Color.green;
            source.clip = correct;
            source.Play();
        }
        else
        {
            bios.transform.position = biosInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }

    //   ------------------------------------------------------------------

    public void DragPorteIo()
    {
        if (!porteIoLocked)
        {
            porteIo.transform.position = Input.mousePosition;
        }
    }

    public void DropPorteIo()
    {
        float Distance = Vector3.Distance(porteIo.transform.position, porteIoBlack.transform.position);
        if (Distance < 50)
        {
            porteIoLocked = true;
            porteIo.transform.localScale = porteIoBlack.transform.localScale;
            porteIo.transform.position = porteIoBlack.transform.position;
            porteIoText.color = Color.green;
            source.clip = correct;
            source.Play();
            porteIoBlack.SetActive(false);
        }
        else
        {
            porteIo.transform.position = porteIoInitialPos;
            source.clip = incorrect;
            source.Play();
        }
    }
























    // Update is called once per frame
    void Update()
    {
        if (cpuLocked && expansionLocked && videoLocked && chipsetLocked && ramLocked && batteriaCMOSLocked && biosLocked && finalImageCanvasGroup != null && finalImageCanvasGroup.alpha == 0)
        {
            vinto.SetActive(true);
            // finalImage.SetActive(true); // Attiva finalImage
            // StartCoroutine(FadeIn(finalImageCanvasGroup, fadeDuration)); // Avvia la dissolvenza
        }
    }

    // Coroutine per la dissolvenza
    private IEnumerator FadeIn(CanvasGroup canvasGroup, float duration)
    {
        float startAlpha = canvasGroup.alpha;
        float time = 0;

        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, 1, time / duration);
            yield return null;
        }

        canvasGroup.alpha = 1; // Assicura che l'alpha sia esattamente 1 alla fine
    }
}
