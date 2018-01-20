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
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using uFrame.MVVM.Bindings;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public partial class HealthEntityViewModelBase : EntityCommonViewModel {
        
        private P<Int32> _HP_MaxProperty;
        
        private P<Int32> _HPProperty;
        
        private Signal<OnRespawnCommand> _OnRespawn;
        
        private Signal<OnDeadCommand> _OnDead;
        
        public HealthEntityViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<Int32> HP_MaxProperty {
            get {
                return _HP_MaxProperty;
            }
            set {
                _HP_MaxProperty = value;
            }
        }
        
        public virtual P<Int32> HPProperty {
            get {
                return _HPProperty;
            }
            set {
                _HPProperty = value;
            }
        }
        
        public virtual Int32 HP_Max {
            get {
                return HP_MaxProperty.Value;
            }
            set {
                HP_MaxProperty.Value = value;
            }
        }
        
        public virtual Int32 HP {
            get {
                return HPProperty.Value;
            }
            set {
                HPProperty.Value = value;
            }
        }
        
        public virtual Signal<OnRespawnCommand> OnRespawn {
            get {
                return _OnRespawn;
            }
            set {
                _OnRespawn = value;
            }
        }
        
        public virtual Signal<OnDeadCommand> OnDead {
            get {
                return _OnDead;
            }
            set {
                _OnDead = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            this.OnRespawn = new Signal<OnRespawnCommand>(this);
            this.OnDead = new Signal<OnDeadCommand>(this);
            _HP_MaxProperty = new P<Int32>(this, "HP_Max");
            _HPProperty = new P<Int32>(this, "HP");
        }
        
        public virtual void Execute(OnRespawnCommand argument) {
            this.OnRespawn.OnNext(argument);
        }
        
        public virtual void Execute(OnDeadCommand argument) {
            this.OnDead.OnNext(argument);
        }
        
        public virtual void OnRespawn_(Vector3 RespawnPosition) {
            var cmd = new OnRespawnCommand();
            cmd.RespawnPosition = RespawnPosition;
            this.OnRespawn.OnNext(cmd);
        }
        
        public virtual void OnDead_() {
            var cmd = new OnDeadCommand();
            this.OnDead.OnNext(cmd);
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            this.HP_Max = stream.DeserializeInt("HP_Max");;
            this.HP = stream.DeserializeInt("HP");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeInt("HP_Max", this.HP_Max);
            stream.SerializeInt("HP", this.HP);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
            list.Add(new ViewModelCommandInfo("OnRespawn", OnRespawn) { ParameterType = typeof(OnRespawnCommand) });
            list.Add(new ViewModelCommandInfo("OnDead", OnDead) { ParameterType = typeof(OnDeadCommand) });
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_HP_MaxProperty, false, false, false, false));
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_HPProperty, false, false, false, false));
        }
    }
    
    public partial class HealthEntityViewModel {
        
        public HealthEntityViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
