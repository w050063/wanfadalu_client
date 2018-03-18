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
    
    
    public partial class PropSystemViewModelBase : ArenaSystemViewModel {
        
        private P<System.Object> _propListProperty;
        
        private Signal<OnPullStorePropListReturnCommand> _OnPullStorePropListReturn;
        
        private Signal<RequestPullStorePropListCommand> _RequestPullStorePropList;
        
        public PropSystemViewModelBase(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
        
        public virtual P<System.Object> propListProperty {
            get {
                return _propListProperty;
            }
            set {
                _propListProperty = value;
            }
        }
        
        public virtual object propList {
            get {
                return propListProperty.Value;
            }
            set {
                propListProperty.Value = value;
            }
        }
        
        public virtual Signal<OnPullStorePropListReturnCommand> OnPullStorePropListReturn {
            get {
                return _OnPullStorePropListReturn;
            }
            set {
                _OnPullStorePropListReturn = value;
            }
        }
        
        public virtual Signal<RequestPullStorePropListCommand> RequestPullStorePropList {
            get {
                return _RequestPullStorePropList;
            }
            set {
                _RequestPullStorePropList = value;
            }
        }
        
        public override void Bind() {
            base.Bind();
            this.OnPullStorePropListReturn = new Signal<OnPullStorePropListReturnCommand>(this);
            this.RequestPullStorePropList = new Signal<RequestPullStorePropListCommand>(this);
            _propListProperty = new P<System.Object>(this, "propList");
        }
        
        public virtual void Execute(OnPullStorePropListReturnCommand argument) {
            this.OnPullStorePropListReturn.OnNext(argument);
        }
        
        public virtual void Execute(RequestPullStorePropListCommand argument) {
            this.RequestPullStorePropList.OnNext(argument);
        }
        
        public virtual void OnPullStorePropListReturn_(Int32 NpcID, object StorePropList) {
            var cmd = new OnPullStorePropListReturnCommand();
            cmd.NpcID = NpcID;
            cmd.StorePropList = StorePropList;
            this.OnPullStorePropListReturn.OnNext(cmd);
        }
        
        public virtual void RequestPullStorePropList_(Int32 StoreNpcID) {
            var cmd = new RequestPullStorePropListCommand();
            cmd.StoreNpcID = StoreNpcID;
            this.RequestPullStorePropList.OnNext(cmd);
        }
        
        public override void Read(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Read(stream);
        }
        
        public override void Write(uFrame.Kernel.Serialization.ISerializerStream stream) {
            base.Write(stream);
        }
        
        protected override void FillCommands(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelCommandInfo> list) {
            base.FillCommands(list);
            list.Add(new ViewModelCommandInfo("OnPullStorePropListReturn", OnPullStorePropListReturn) { ParameterType = typeof(OnPullStorePropListReturnCommand) });
            list.Add(new ViewModelCommandInfo("RequestPullStorePropList", RequestPullStorePropList) { ParameterType = typeof(RequestPullStorePropListCommand) });
        }
        
        protected override void FillProperties(System.Collections.Generic.List<uFrame.MVVM.ViewModels.ViewModelPropertyInfo> list) {
            base.FillProperties(list);
            // PropertiesChildItem
            list.Add(new ViewModelPropertyInfo(_propListProperty, false, false, false, false));
        }
    }
    
    public partial class PropSystemViewModel {
        
        public PropSystemViewModel(uFrame.Kernel.IEventAggregator aggregator) : 
                base(aggregator) {
        }
    }
}
