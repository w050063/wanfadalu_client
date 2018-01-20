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
    
    
    public class ArenaSystemViewBase : SkillEntityView {
        
        [uFrame.MVVM.Attributes.UFToggleGroup("OnEnterArena")]
        [UnityEngine.HideInInspector()]
        public bool _BindOnEnterArena = true;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("OnExitArena")]
        [UnityEngine.HideInInspector()]
        public bool _BindOnExitArena = true;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("OnMatchEnd")]
        [UnityEngine.HideInInspector()]
        public bool _BindOnMatchEnd = true;
        
        public override string DefaultIdentifier {
            get {
                return base.DefaultIdentifier;
            }
        }
        
        public override System.Type ViewModelType {
            get {
                return typeof(ArenaSystemViewModel);
            }
        }
        
        public ArenaSystemViewModel ArenaSystem {
            get {
                return (ArenaSystemViewModel)ViewModelObject;
            }
        }
        
        protected override void InitializeViewModel(uFrame.MVVM.ViewModels.ViewModel model) {
            base.InitializeViewModel(model);
            // NOTE: this method is only invoked if the 'Initialize ViewModel' is checked in the inspector.
            // var vm = model as ArenaSystemViewModel;
            // This method is invoked when applying the data from the inspector to the viewmodel.  Add any view-specific customizations here.
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.ArenaSystem to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindOnEnterArena) {
                this.BindCommandExecuted(this.ArenaSystem.OnEnterArena, this.OnEnterArenaExecuted);
            }
            if (_BindOnExitArena) {
                this.BindCommandExecuted(this.ArenaSystem.OnExitArena, this.OnExitArenaExecuted);
            }
            if (_BindOnMatchEnd) {
                this.BindCommandExecuted(this.ArenaSystem.OnMatchEnd, this.OnMatchEndExecuted);
            }
        }
        
        public virtual void OnEnterArenaExecuted(OnEnterArenaCommand command) {
        }
        
        public virtual void OnExitArenaExecuted(OnExitArenaCommand command) {
        }
        
        public virtual void OnMatchEndExecuted(OnMatchEndCommand command) {
        }
        
        public virtual void ExecuteRequestEnterArena(RequestEnterArenaCommand command) {
            command.Sender = ArenaSystem;
            ArenaSystem.RequestEnterArena.OnNext(command);
        }
        
        public virtual void ExecuteOnExitArena(OnExitArenaCommand command) {
            command.Sender = ArenaSystem;
            ArenaSystem.OnExitArena.OnNext(command);
        }
        
        public virtual void ExecuteRequestExitArena(RequestExitArenaCommand command) {
            command.Sender = ArenaSystem;
            ArenaSystem.RequestExitArena.OnNext(command);
        }
        
        public virtual void ExecuteOnEnterArena(OnEnterArenaCommand command) {
            command.Sender = ArenaSystem;
            ArenaSystem.OnEnterArena.OnNext(command);
        }
        
        public virtual void ExecuteOnMatchEnd(OnMatchEndCommand command) {
            command.Sender = ArenaSystem;
            ArenaSystem.OnMatchEnd.OnNext(command);
        }
    }
}
