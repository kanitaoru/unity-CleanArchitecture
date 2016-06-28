using UnityEngine;
using System.Collections;

/// 画面ごとのPresenter
/// 必要な UseCase からモデルをもらう
/// Viewから支持をもらって動く
public class FriendListPresenter : IFriendListUseCaseOutput
{
	FriendListUseCase usecase;
	public IFriendListViewController viewController;

	public void RequestFriendList()
	{
		this.usecase = new FriendListUseCase();
		this.usecase.output = this;
		this.usecase.GetFriendList();
	}

	#pragma IFriendListUseCaseOutput

	public void DidLoadFriendList(FriendListModel model)
	{
		this.viewController.SetFriendListModel(model);
	}
}
