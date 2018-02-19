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
    
    
    public class MainAvatarInfoPanelViewBase : EntityCommonView {
        
        [uFrame.MVVM.Attributes.UFToggleGroup("HP")]
        [UnityEngine.HideInInspector()]
        public bool _BindHP = true;
        
        [uFrame.MVVM.Attributes.UFGroup("HP")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_HPonlyWhenChanged")]
        protected bool _HPOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("HP_Max")]
        [UnityEngine.HideInInspector()]
        public bool _BindHP_Max = true;
        
        [uFrame.MVVM.Attributes.UFGroup("HP_Max")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_HP_MaxonlyWhenChanged")]
        protected bool _HP_MaxOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("magicWeaponList")]
        [UnityEngine.HideInInspector()]
        public bool _BindmagicWeaponList = true;
        
        [uFrame.MVVM.Attributes.UFGroup("magicWeaponList")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_magicWeaponListonlyWhenChanged")]
        protected bool _magicWeaponListOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("MSP_Max")]
        [UnityEngine.HideInInspector()]
        public bool _BindMSP_Max = true;
        
        [uFrame.MVVM.Attributes.UFGroup("MSP_Max")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_MSP_MaxonlyWhenChanged")]
        protected bool _MSP_MaxOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("SP_Max")]
        [UnityEngine.HideInInspector()]
        public bool _BindSP_Max = true;
        
        [uFrame.MVVM.Attributes.UFGroup("SP_Max")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_SP_MaxonlyWhenChanged")]
        protected bool _SP_MaxOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("SP")]
        [UnityEngine.HideInInspector()]
        public bool _BindSP = true;
        
        [uFrame.MVVM.Attributes.UFGroup("SP")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_SPonlyWhenChanged")]
        protected bool _SPOnlyWhenChanged;
        
        [uFrame.MVVM.Attributes.UFToggleGroup("MSP")]
        [UnityEngine.HideInInspector()]
        public bool _BindMSP = true;
        
        [uFrame.MVVM.Attributes.UFGroup("MSP")]
        [UnityEngine.SerializeField()]
        [UnityEngine.HideInInspector()]
        [UnityEngine.Serialization.FormerlySerializedAsAttribute("_MSPonlyWhenChanged")]
        protected bool _MSPOnlyWhenChanged;
        
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
            var mainavatarinfopanelview = ((AvatarViewModel)model);
        }
        
        public override void Bind() {
            base.Bind();
            // Use this.Avatar to access the viewmodel.
            // Use this method to subscribe to the view-model.
            // Any designer bindings are created in the base implementation.
            if (_BindHP) {
                this.BindProperty(this.Avatar.HPProperty, this.HPChanged, _HPOnlyWhenChanged);
            }
            if (_BindHP_Max) {
                this.BindProperty(this.Avatar.HP_MaxProperty, this.HP_MaxChanged, _HP_MaxOnlyWhenChanged);
            }
            if (_BindmagicWeaponList) {
                this.BindProperty(this.Avatar.magicWeaponListProperty, this.magicWeaponListChanged, _magicWeaponListOnlyWhenChanged);
            }
            if (_BindMSP_Max) {
                this.BindProperty(this.Avatar.MSP_MaxProperty, this.MSP_MaxChanged, _MSP_MaxOnlyWhenChanged);
            }
            if (_BindSP_Max) {
                this.BindProperty(this.Avatar.SP_MaxProperty, this.SP_MaxChanged, _SP_MaxOnlyWhenChanged);
            }
            if (_BindSP) {
                this.BindProperty(this.Avatar.SPProperty, this.SPChanged, _SPOnlyWhenChanged);
            }
            if (_BindMSP) {
                this.BindProperty(this.Avatar.MSPProperty, this.MSPChanged, _MSPOnlyWhenChanged);
            }
        }
        
        public virtual void HPChanged(Int32 arg1) {
        }
        
        public virtual void HP_MaxChanged(Int32 arg1) {
        }
        
        public virtual void magicWeaponListChanged(object arg1) {
        }
        
        public virtual void MSP_MaxChanged(Int32 arg1) {
        }
        
        public virtual void SP_MaxChanged(Int32 arg1) {
        }
        
        public virtual void SPChanged(Int32 arg1) {
        }
        
        public virtual void MSPChanged(Int32 arg1) {
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
