﻿/* --------------------------
 * Company: MagicFire Studio
 *   Autor: Changmin Yang
 *    Date: 2017/02/20
 *    描述： 
 * -------------------------- */
namespace MagicFire.Mmorpg
{
    using System;
    using UnityEngine;
    using System.Collections;
    using Mmorpg.UI;
    using MagicFire.Common;
    using KBEngine;
    using Model = KBEngine.Model;

    public abstract class EntityObjectView : View
    {
        public string EntityName { get; set; }

        public override void InitializeView(IModel model)
        {
            base.InitializeView(model);
            EntityName_Up(0);
            model.SubscribePropertyUpdate(KBEngine.Avatar.EntityObject.entityName, EntityName_Up);
        }

        public override void OnModelDestroy(object[] objects)
        {
            if (Model != null)
            {
                Model.DesubscribePropertyUpdate(KBEngine.Avatar.EntityObject.entityName, EntityName_Up);
                ((KBEngine.Model)Model).renderObj = null;
            }
            base.OnModelDestroy(objects);
        }

        public void EntityName_Up(object val)
        {
            if (EntityName == (string)((KBEngine.Model)Model).getDefinedProperty(KBEngine.Avatar.EntityObject.entityName))
                return;
            EntityName = (string)((KBEngine.Model)Model).getDefinedProperty(KBEngine.Avatar.EntityObject.entityName);
            var obj = ((KBEngine.Model)Model).renderObj as GameObject;
            if (obj != null)
            {
                obj.name = ((KBEngine.Model)Model).className + ":" + EntityName;
            }
        }
    }
}
