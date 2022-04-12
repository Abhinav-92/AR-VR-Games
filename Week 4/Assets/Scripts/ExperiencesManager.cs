using UnityEngine;
using UnityEngine.UI;

public class ExperiencesManager : MonoBehaviour
{
    int _index = 0;

    private void Awake()
    {
        ChangeExperience(0);
    }

    public void ChangeExperience(int _change)
    {
        if (_index == transform.childCount-1 && _change == 1)
            _index = 0;
        else if (_index == 0 && _change == -1)
            _index = transform.childCount-1;
        else
            _index += _change;

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }
}