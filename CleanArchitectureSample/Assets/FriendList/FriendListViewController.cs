using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public interface IFriendListViewController
{
	void SetFriendListModel(FriendListModel model);
}

/// 実際のView
/// 表示したいGameObjectにはりつけるんでいいと思う
/// Presenterに状態やしてほしいことを指示出しする
public class FriendListViewController : MonoBehaviour, IFriendListViewController
{
	[SerializeField] Text friendCellBase;

	IEnumerable<FriendModel> friends;
	FriendListPresenter presenter = new FriendListPresenter();

	void Start()
	{
		this.friendCellBase.gameObject.SetActive(false);

		this.presenter.viewController = this;
		this.presenter.RequestFriendList();
	}

	#pragma IFriendListViewController

	public void SetFriendListModel(FriendListModel model)
	{
		this.friends = model.friends;

		float lastY = this.friendCellBase.rectTransform.anchoredPosition.y;

		foreach (var friend in model.friends)
		{
			var obj = GameObject.Instantiate<GameObject>(friendCellBase.gameObject);
			obj.SetActive(true);
			
			var nameText = obj.GetComponent<Text>();
			nameText.text = friend.name;

			obj.transform.SetParent(this.friendCellBase.transform.parent, false);
			obj.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, lastY, 0);
			lastY += 30;
		}
	}
}
