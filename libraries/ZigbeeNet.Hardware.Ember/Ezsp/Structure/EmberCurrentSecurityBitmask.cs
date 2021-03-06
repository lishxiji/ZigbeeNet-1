//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Structure
{
    
    
    /// <summary>
    /// Class to implement the Ember Enumeration <b>EmberCurrentSecurityBitmask</b>
    /// </summary>
    public enum EmberCurrentSecurityBitmask
    {
        
        /// <summary>
        /// Default unknown value
        /// </summary>
        UNKNOWN = -1,
        
        /// <summary>
        ///  [0] This denotes that the device is running in a network with ZigBee Standard Security.
        /// </summary>
        EMBER_STANDARD_SECURITY_MODE = 0x0000,
        
        /// <summary>
        ///  [1] This denotes that the device is running in a network with ZigBee High Security.
        /// </summary>
        EMBER_HIGH_SECURITY_MODE = 0x0001,
        
        /// <summary>
        ///  [2] This denotes that the device is running in a network without a centralized Trust Center.
        /// </summary>
        EMBER_DISTRIBUTED_TRUST_CENTER_MODE = 0x0002,
        
        /// <summary>
        ///  [4] This denotes that the device has a Global Link Key. The Trust Center Link Key is the same
        /// across multiple nodes.
        /// </summary>
        EMBER_GLOBAL_LINK_KEY = 0x0004,
        
        /// <summary>
        ///  [16] This denotes that the node has a Trust Center Link Key.
        /// </summary>
        EMBER_HAVE_TRUST_CENTER_LINK_KEY = 0x0010,
        
        /// <summary>
        ///  [132] This denotes that the Trust Center is using a Hashed Link Key.
        /// </summary>
        EMBER_TRUST_CENTER_USES_HASHED_LINK_KEY = 0x0084,
    }
}
