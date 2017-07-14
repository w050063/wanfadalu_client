﻿namespace MagicFire.Mmorpg
{
    using UnityEngine;
    using System;
    using System.Collections;
    using Mmorpg.UI;
    using KBEngine;
    using MagicFire.Common;
    using MagicFire.Mmorpg.Skill;

    public class AvatarView : CombatEntityObjectView
    {
        [SerializeField]
        [Range(0.1f, 1.0f)]
        private float _speed;
        [SerializeField]
        private Animator _animator;
        [SerializeField]
        private Animation _animation;
        [SerializeField]
        private CharacterController _characterController;

        private AvatarState _avatarState;
        private StandState _standState;
        private RunState _runState;
        private DeadState _deadState;

        public SkillManager SkillManager
        {
            get;
            set;
        }

        public float Speed
        {
            get { return _speed; }
        }

        public Animator Animator
        {
            get
            {
                return _animator;
            }
        }

        public Animation Animation
        {
            get
            {
                return _animation;
            }
        }

        public CharacterController CharacterController
        {
            get
            {
                return _characterController;
            }
        }

        public int Sp { get; set; }

        public int SpMax { get; set; }

        // Use this for initialization
        private void Start()
        {
            SkillManager = new SkillManager { Owner = this };
            SkillManager.Init();

            _standState = new StandState(this);
            _runState = new RunState(this);
            _deadState = new DeadState(this);
            _avatarState = _standState;
        }

        // Update is called once per frame
        private void Update()
        {
            SkillManager.Update();
            _avatarState.Run();
            transform.GetChild(0).localPosition = Vector3.zero;
        }

        public override void InitializeView(IModel model)
        {
            base.InitializeView(model);
            Model.SubscribeMethodCall("DoMove", DoMove);
            Model.SubscribeMethodCall("OnStopMove", OnStopMove);
            //郑晓飞---发送聊天信息
            Model.SubscribeMethodCall("onReciveChatMessage", onReciveChatMessage);
        }

        public override void OnModelDestrooy(object[] objects)
        {
            Model.DesubscribeMethodCall("DoMove", DoMove);
            Model.DesubscribeMethodCall("OnStopMove", OnStopMove);
            base.OnModelDestrooy(objects);
        }

        protected override void OnDie(object[] args)
        {
            _avatarState = _deadState;
            PlayerInputController.instance.enabled = false;
            SingletonGather.UiManager.TryGetOrCreatePanel("DeadPanel").SetActive(true);
            transform.GetChild(0).localEulerAngles = new Vector3(0, 1, 90);
            base.OnDie(args);
        }

        protected override void OnRespawn(object[] args)
        {
            gameObject.transform.position = (Vector3)args[0];
            PlayerInputController.instance.enabled = true;
            SingletonGather.UiManager.TryGetOrCreatePanel("DeadPanel").SetActive(false);
            transform.GetChild(0).localEulerAngles = new Vector3(0, 1, 0);
        }

        public void DoMove(object[] args)
        {
            _avatarState = _runState;
        }

        public void OnStopMove(object[] args)
        {
            _avatarState = _standState;
        }

        //郑晓飞-----聊天框
        private void onReciveChatMessage(object[] obj)
        {
            SingletonGather.UiManager.TryGetOrCreatePanel("PlayerDialogPanel").GetComponent<PlayerDialogPanel>().DialogContent(obj);
        }

        private class AvatarState
        {
            protected readonly AvatarView AvatarView;

            protected AvatarState(AvatarView avatarView)
            {
                AvatarView = avatarView;
            }

            public virtual void Run()
            {

            }

            public virtual void FixedRun()
            {

            }
        }

        private class StandState : AvatarState
        {
            public StandState(AvatarView avatarView)
                : base(avatarView)
            {

            }

            public override void Run()
            {
                base.Run();
                if (AvatarView._animator)
                {
                    AvatarView._animator.SetFloat("Speed", 0.0f);
                }
            }
        }

        private class RunState : AvatarState
        {
            public RunState(AvatarView avatarView)
                : base(avatarView)
            {

            }

            public override void Run()
            {
                base.Run();
                if (AvatarView._animator)
                {
                    if (AvatarView._animator.GetCurrentAnimatorStateInfo(0).IsName("Locomotion") ||
                        AvatarView._animator.GetCurrentAnimatorStateInfo(0).IsName("Jump") ||
                        AvatarView._animator.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
                    {
                        AvatarView._animator.SetFloat("Speed", 1.0f);
                    }
                }
            }
        }

        private class DeadState : AvatarState
        {
            public DeadState(AvatarView avatarView)
                : base(avatarView)
            {

            }
        }
    }
}