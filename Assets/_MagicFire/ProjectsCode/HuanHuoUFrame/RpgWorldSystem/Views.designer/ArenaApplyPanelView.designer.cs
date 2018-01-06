// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MagicFire.HuanHuoUFrame {
    using MagicFire.HuanHuoUFrame;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.Services;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class ArenaApplyPanelViewBase : PanelView {
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public object _avatarBag;
        
        [UnityEngine.SerializeField()]
        [uFrame.MVVM.Attributes.UFGroup("View Model Properties")]
        [UnityEngine.HideInInspector()]
        public Int32 _goldCount;
        
        public override string DefaultIdentifier {
            get {
                return base.DefaultIdentifier;
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(AvatarViewModel);
            }
        }
        
        public AvatarViewModel Avatar {
            get {
                return (AvatarViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as AvatarViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
            var arenaapplypanelview = ((AvatarViewModel)model);
            arenaapplypanelview.avatarBag = this._avatarBag;
            arenaapplypanelview.goldCount = this._goldCount;
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.Avatar to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
        }
        
        public virtual void ExecuteonMainAvatarEnterSpace(onMainAvatarEnterSpaceCommand command) {
            command.Sender = Avatar;
            Avatar.onMainAvatarEnterSpace.OnNext(command);
        }
        
        public virtual void ExecuteonMainAvatarLeaveSpace(onMainAvatarLeaveSpaceCommand command) {
            command.Sender = Avatar;
            Avatar.onMainAvatarLeaveSpace.OnNext(command);
        }
    }
}
