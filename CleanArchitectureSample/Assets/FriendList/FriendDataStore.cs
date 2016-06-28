using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

/// Entityを取得してくるクラス
public class FriendDataStore
{
    public void RequestFriendList(Action<IEnumerable<FriendEntity>> onSuccess)
    {
        var list = new List<FriendEntity>();
        
        var friend1 = new FriendEntity();
        friend1.name = "test1";

        var friend2 = new FriendEntity();
        friend2.name = "test2";

        list.Add(friend1);
        list.Add(friend2);

        onSuccess(list);
    }
}
