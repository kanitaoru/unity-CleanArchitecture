using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FriendListModel
{
	public IEnumerable<FriendModel> friends;
}

/// 画面表示に適したモデル
public class FriendModel
{
	public string name;

	public FriendModel(FriendEntity entity)
	{
		this.name = string.IsNullOrEmpty(entity.name) ? "No Name" : entity.name;
	}
}
