using UnityEngine;
using System.Collections;

public interface IFriendListUseCaseOutput
{
	void DidLoadFriendList(FriendListModel model);
}

public class FriendListUseCase
{
	public IFriendListUseCaseOutput output;

	public void GetFriendList()
	{
		var repository = new FriendRepository();
		repository.RequestFriendList(onSuccess: (friendList) =>
		{
			// friendListはentityの塊なのでModelに変換する
			var friendListModel = FriendListTranslater.GenerateFriendList(friendList);
			
			if (this.output != null)
			{
				this.output.DidLoadFriendList(friendListModel);
			}
		});
	}
}
