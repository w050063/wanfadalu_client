namespace KbeBalls {
    using KbeBalls;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.IOC;
    using uFrame.Kernel;
    using uFrame.Kernel.Serialization;
    using uFrame.MVVM;
    using UnityEngine;
    
    
    public class LoginSceneLoader : LoginSceneLoaderBase {
        
        protected override IEnumerator LoadScene(LoginScene scene, Action<float, string> progressDelegate) {
            yield break;
        }
        
        protected override IEnumerator UnloadScene(LoginScene scene, Action<float, string> progressDelegate) {
            yield break;
        }
    }
}
