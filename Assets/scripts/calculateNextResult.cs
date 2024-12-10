using UnityEngine;
using UnityEngine.SceneManagement;


public class calculateNextResult : MonoBehaviour
{
    [SerializeField] string areaTag;
    [SerializeField] double gazaProb = 0.3;
    [SerializeField] double wbProb = 0.5;
    [SerializeField] double LebanonProb = 0.2;
    [SerializeField] double iranProb = 0.1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void clicker()
    {
        switch (areaTag)
        {
            case "Gaza":
                if (!(GetRandomBoolean(gazaProb)))
                {
                    SuccessOptions();
                }
                else
                {
                    FailureOptions();
                }
                break;
            case "West Bank":
                if (!(GetRandomBoolean(wbProb)))
                {
                    SuccessOptions();
                }
                else
                {
                    FailureOptions();
                }
                break;
            case "Lebanon":
                if (!(GetRandomBoolean(LebanonProb)))
                {
                    SuccessOptions();
                }
                else
                {
                    FailureOptions();
                }
                break;
            default:
                break;
        }
    }

    void SuccessOptions()
    {
        if (GetRandomBoolean(iranProb))
        {
            SceneManager.LoadScene("Victory");
        }
        else
        {
            SceneManager.LoadScene("Success");
        }
    }

    void FailureOptions()
    {
        if (GetRandomBoolean(iranProb))
        {
            SceneManager.LoadScene("Defeat");
        }
        else
        {
            SceneManager.LoadScene("Failure");
        }
    }

    static bool GetRandomBoolean(double prob)
    {
        System.Random random = new System.Random();
        double randomVal = random.NextDouble();
        return randomVal < prob;
    }
}
