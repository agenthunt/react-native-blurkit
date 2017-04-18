using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNBlurKit
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNBlurKitModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNBlurKitModule"/>.
        /// </summary>
        internal RNBlurKitModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNBlurKit";
            }
        }
    }
}
