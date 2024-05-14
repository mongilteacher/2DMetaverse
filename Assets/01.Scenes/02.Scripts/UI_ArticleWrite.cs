using UnityEngine;
using UnityEngine.UI;

public class UI_ArticleWrite : MonoBehaviour
{
    public UI_ArticleList ArticleListUI;
    public Toggle NoticeToggleUI;
    public InputField ContentInputFieldUI;
    
    public void OnClickExitButton()
    {
        ArticleListUI.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void OnClickWriteButton()
    {
        ArticleType articleType = NoticeToggleUI.isOn ? ArticleType.Notice : ArticleType.Normal;
        string content = ContentInputFieldUI.text;
        if (string.IsNullOrEmpty(content))
        {
            
        }
      
        ArticleManager.Instance.Write(articleType, content);
        ArticleListUI.Show();
        gameObject.SetActive(false);
    }
}
