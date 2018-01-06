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
    
    
    public partial class ArenaViewModelBase : EntityCommonViewModel {
        
        private P<Int32> _arenaIDProperty;
        
        public ArenaViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<Int32> arenaIDProperty {
            get {
                return _arenaIDProperty;
            }
            set {
                _arenaIDProperty = value;
            }
        }
        
        public virtual Int32 arenaID {
            get {
                return arenaIDProperty.Value;
            }
            set {
                arenaIDProperty.Value = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            _arenaIDProperty = new P<Int32>(this, "arenaID");
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
            this.arenaID = stream.DeserializeInt("arenaID");;
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
            stream.SerializeInt("arenaID", this.arenaID);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_arenaIDProperty, false, false, false, false));
        }
    }
    
    public partial class ArenaViewModel {
        
        public ArenaViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
