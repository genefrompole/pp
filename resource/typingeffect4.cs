using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typingeffect4 : MonoBehaviour
{
    public Text tx;
    private string m_text = "따뜻한데 뭘...요것만 비우고 갈겁니다. 너무 보채지 마세요.";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(0);
        for(int i=0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);

                yield return new WaitForSeconds(0.03f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
