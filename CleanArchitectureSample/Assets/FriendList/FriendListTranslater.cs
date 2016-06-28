using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class FriendListTranslater
{
	public static FriendListModel GenerateFriendList(IEnumerable<FriendEntity> entities)
	{
		var modelList = new List<FriendModel>();
		foreach (var entity in entities)
		{
			var model = new FriendModel(entity);
			modelList.Add(model);
		}

		var listModel = new FriendListModel();
		listModel.friends = modelList;

		return listModel;
	}
}
