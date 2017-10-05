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
    
    
    public class AvatarControllerBase : SkillEntityController {
        
        private uFrame.MVVM.ViewModels.IViewModelManager<AvatarViewModel> _AvatarViewModelManager;
        
        [uFrame.IOC.InjectAttribute("Avatar")]
        public uFrame.MVVM.ViewModels.IViewModelManager<AvatarViewModel> AvatarViewModelManager {
            get {
                return _AvatarViewModelManager;
            }
            set {
                _AvatarViewModelManager = value;
            }
        }
        
        public IEnumerable<AvatarViewModel> AvatarViewModels {
            get {
                return AvatarViewModelManager.ViewModels;
            }
        }
        
        public override void Setup() {
            base.Setup();
            // This is called when the controller is created
        }
        
        public override void Initialize(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.Initialize(viewModel);
            // This is called when a viewmodel is created
            this.InitializeAvatar(((AvatarViewModel)(viewModel)));
        }
        
        public virtual AvatarViewModel CreateAvatar() {
            return ((AvatarViewModel)(this.Create(Guid.NewGuid().ToString())));
        }
        
        public override uFrame.MVVM.ViewModels.ViewModel CreateEmpty() {
            return new AvatarViewModel(this.EventAggregator);
        }
        
        public virtual void InitializeAvatar(AvatarViewModel viewModel) {
            // This is called when a AvatarViewModel is created
            viewModel.onMainAvatarEnterSpace.Action = this.onMainAvatarEnterSpaceHandler;
            viewModel.onMainAvatarLeaveSpace.Action = this.onMainAvatarLeaveSpaceHandler;
            viewModel.DoMove.Action = this.DoMoveHandler;
            viewModel.OnStopMove.Action = this.OnStopMoveHandler;
            AvatarViewModelManager.Add(viewModel);
        }
        
        public override void DisposingViewModel(uFrame.MVVM.ViewModels.ViewModel viewModel) {
            base.DisposingViewModel(viewModel);
            AvatarViewModelManager.Remove(viewModel);
        }
        
        public virtual void onMainAvatarEnterSpaceHandler(onMainAvatarEnterSpaceCommand command) {
            this.onMainAvatarEnterSpace(command.Sender as AvatarViewModel, command);
        }
        
        public virtual void onMainAvatarLeaveSpaceHandler(onMainAvatarLeaveSpaceCommand command) {
            this.onMainAvatarLeaveSpace(command.Sender as AvatarViewModel, command);
        }
        
        public virtual void DoMoveHandler(DoMoveCommand command) {
            this.DoMove(command.Sender as AvatarViewModel, command);
        }
        
        public virtual void OnStopMoveHandler(OnStopMoveCommand command) {
            this.OnStopMove(command.Sender as AvatarViewModel, command);
        }
        
        public virtual void onMainAvatarEnterSpace(AvatarViewModel viewModel, onMainAvatarEnterSpaceCommand arg) {
        }
        
        public virtual void onMainAvatarLeaveSpace(AvatarViewModel viewModel, onMainAvatarLeaveSpaceCommand arg) {
        }
        
        public virtual void DoMove(AvatarViewModel viewModel, DoMoveCommand arg) {
        }
        
        public virtual void OnStopMove(AvatarViewModel viewModel, OnStopMoveCommand arg) {
        }
    }
}
