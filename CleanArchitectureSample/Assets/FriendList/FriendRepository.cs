using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

/// Domain層(UseCase) と Data層(DataStore) の橋渡し
public class FriendRepository
{
	FriendDataStore dataStore = new FriendDataStore();

	public void RequestFriendList(Action<IEnumerable<FriendEntity>> onSuccess)
	{
		dataStore.RequestFriendList(onSuccess: (friendList) =>
		{
			onSuccess(friendList);
		});
	}
}
