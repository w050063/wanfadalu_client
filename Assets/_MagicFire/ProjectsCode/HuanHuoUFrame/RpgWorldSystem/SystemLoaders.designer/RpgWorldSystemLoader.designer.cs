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
    using uFrame.MVVM;
    using uFrame.MVVM.ViewModels;
    using UniRx;
    using UnityEngine;
    
    
    public class RpgWorldSystemLoaderBase : uFrame.Kernel.SystemLoader {
        
        private SuperPowerEntityController _SuperPowerEntityController;
        
        private EntityCommonController _EntityCommonController;
        
        private NpcController _NpcController;
        
        private SpacesManagerController _SpacesManagerController;
        
        private HealthEntityController _HealthEntityController;
        
        private AccountController _AccountController;
        
        private SpaceController _SpaceController;
        
        private CampController _CampController;
        
        private TriggerController _TriggerController;
        
        private SkillEntityController _SkillEntityController;
        
        private AvatarController _AvatarController;
        
        private MonsterController _MonsterController;
        
        [uFrame.IOC.InjectAttribute()]
        public virtual SuperPowerEntityController SuperPowerEntityController {
            get {
                if (_SuperPowerEntityController==null) {
                    _SuperPowerEntityController = Container.CreateInstance(typeof(SuperPowerEntityController)) as SuperPowerEntityController;;
                }
                return _SuperPowerEntityController;
            }
            set {
                _SuperPowerEntityController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual EntityCommonController EntityCommonController {
            get {
                if (_EntityCommonController==null) {
                    _EntityCommonController = Container.CreateInstance(typeof(EntityCommonController)) as EntityCommonController;;
                }
                return _EntityCommonController;
            }
            set {
                _EntityCommonController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual NpcController NpcController {
            get {
                if (_NpcController==null) {
                    _NpcController = Container.CreateInstance(typeof(NpcController)) as NpcController;;
                }
                return _NpcController;
            }
            set {
                _NpcController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual SpacesManagerController SpacesManagerController {
            get {
                if (_SpacesManagerController==null) {
                    _SpacesManagerController = Container.CreateInstance(typeof(SpacesManagerController)) as SpacesManagerController;;
                }
                return _SpacesManagerController;
            }
            set {
                _SpacesManagerController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual HealthEntityController HealthEntityController {
            get {
                if (_HealthEntityController==null) {
                    _HealthEntityController = Container.CreateInstance(typeof(HealthEntityController)) as HealthEntityController;;
                }
                return _HealthEntityController;
            }
            set {
                _HealthEntityController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual AccountController AccountController {
            get {
                if (_AccountController==null) {
                    _AccountController = Container.CreateInstance(typeof(AccountController)) as AccountController;;
                }
                return _AccountController;
            }
            set {
                _AccountController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual SpaceController SpaceController {
            get {
                if (_SpaceController==null) {
                    _SpaceController = Container.CreateInstance(typeof(SpaceController)) as SpaceController;;
                }
                return _SpaceController;
            }
            set {
                _SpaceController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual CampController CampController {
            get {
                if (_CampController==null) {
                    _CampController = Container.CreateInstance(typeof(CampController)) as CampController;;
                }
                return _CampController;
            }
            set {
                _CampController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual TriggerController TriggerController {
            get {
                if (_TriggerController==null) {
                    _TriggerController = Container.CreateInstance(typeof(TriggerController)) as TriggerController;;
                }
                return _TriggerController;
            }
            set {
                _TriggerController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual SkillEntityController SkillEntityController {
            get {
                if (_SkillEntityController==null) {
                    _SkillEntityController = Container.CreateInstance(typeof(SkillEntityController)) as SkillEntityController;;
                }
                return _SkillEntityController;
            }
            set {
                _SkillEntityController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual AvatarController AvatarController {
            get {
                if (_AvatarController==null) {
                    _AvatarController = Container.CreateInstance(typeof(AvatarController)) as AvatarController;;
                }
                return _AvatarController;
            }
            set {
                _AvatarController = value;
            }
        }
        
        [uFrame.IOC.InjectAttribute()]
        public virtual MonsterController MonsterController {
            get {
                if (_MonsterController==null) {
                    _MonsterController = Container.CreateInstance(typeof(MonsterController)) as MonsterController;;
                }
                return _MonsterController;
            }
            set {
                _MonsterController = value;
            }
        }
        
        public override void Load() {
            Container.RegisterViewModelManager<SuperPowerEntityViewModel>(new ViewModelManager<SuperPowerEntityViewModel>());
            Container.RegisterController<SuperPowerEntityController>(SuperPowerEntityController);
            Container.RegisterViewModelManager<EntityCommonViewModel>(new ViewModelManager<EntityCommonViewModel>());
            Container.RegisterController<EntityCommonController>(EntityCommonController);
            Container.RegisterViewModelManager<NpcViewModel>(new ViewModelManager<NpcViewModel>());
            Container.RegisterController<NpcController>(NpcController);
            Container.RegisterViewModelManager<SpacesManagerViewModel>(new ViewModelManager<SpacesManagerViewModel>());
            Container.RegisterController<SpacesManagerController>(SpacesManagerController);
            Container.RegisterViewModelManager<HealthEntityViewModel>(new ViewModelManager<HealthEntityViewModel>());
            Container.RegisterController<HealthEntityController>(HealthEntityController);
            Container.RegisterViewModelManager<AccountViewModel>(new ViewModelManager<AccountViewModel>());
            Container.RegisterController<AccountController>(AccountController);
            Container.RegisterViewModelManager<SpaceViewModel>(new ViewModelManager<SpaceViewModel>());
            Container.RegisterController<SpaceController>(SpaceController);
            Container.RegisterViewModelManager<CampViewModel>(new ViewModelManager<CampViewModel>());
            Container.RegisterController<CampController>(CampController);
            Container.RegisterViewModelManager<TriggerViewModel>(new ViewModelManager<TriggerViewModel>());
            Container.RegisterController<TriggerController>(TriggerController);
            Container.RegisterViewModelManager<SkillEntityViewModel>(new ViewModelManager<SkillEntityViewModel>());
            Container.RegisterController<SkillEntityController>(SkillEntityController);
            Container.RegisterViewModelManager<AvatarViewModel>(new ViewModelManager<AvatarViewModel>());
            Container.RegisterController<AvatarController>(AvatarController);
            Container.RegisterViewModelManager<MonsterViewModel>(new ViewModelManager<MonsterViewModel>());
            Container.RegisterController<MonsterController>(MonsterController);
        }
    }
}
