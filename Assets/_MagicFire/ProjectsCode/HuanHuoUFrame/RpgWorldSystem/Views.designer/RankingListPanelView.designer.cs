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
    
    
    public class RankingListPanelViewBase : PanelView {
        
        [uFrame.MVVM.Attributes.UFToggleGroup("RequestSelfRanking")]
        [UnityEngine.HideInInspector()]
        public bool _BindRequestSelfRanking = true;
        
        [uFrame.MVVM.Attributes.UFGroup("RequestSelfRanking")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_RequestSelfRankingbutton")]
        protected UnityEngine.UI.Button _RequestSelfRankingButton;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("RequestRankingList")]
        [UnityEngine.HideInInspector()]
        public bool _BindRequestRankingList = true;
        
        [uFrame.MVVM.Attributes.UFGroup("RequestRankingList")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_RequestRankingListbutton")]
        protected UnityEngine.UI.Button _RequestRankingListButton;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("OnRequestRankingListReturn")]
        [UnityEngine.HideInInspector()]
        public bool _BindOnRequestRankingListReturn = true;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("OnRequestSelfRankingReturn")]
        [UnityEngine.HideInInspector()]
        public bool _BindOnRequestSelfRankingReturn = true;
        
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
            var rankinglistpanelview = ((AvatarViewModel)model);
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.Avatar to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindRequestSelfRanking) {
                this.BindButtonToCommand(_RequestSelfRankingButton, this.Avatar.RequestSelfRanking);
            }
            if (_BindRequestRankingList) {
                this.BindButtonToCommand(_RequestRankingListButton, this.Avatar.RequestRankingList);
            }
            if (_BindOnRequestRankingListReturn) {
                this.BindCommandExecuted(this.Avatar.OnRequestRankingListReturn, this.OnRequestRankingListReturnExecuted);
            }
            if (_BindOnRequestSelfRankingReturn) {
                this.BindCommandExecuted(this.Avatar.OnRequestSelfRankingReturn, this.OnRequestSelfRankingReturnExecuted);
            }
        }
        
        public virtual void OnRequestRankingListReturnExecuted(OnRequestRankingListReturnCommand command) {
        }
        
        public virtual void OnRequestSelfRankingReturnExecuted(OnRequestSelfRankingReturnCommand command) {
        }
        
        public virtual void ExecuteTeleport(TeleportCommand command) {
            command.Sender = Avatar;
            Avatar.Teleport.OnNext(command);
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
