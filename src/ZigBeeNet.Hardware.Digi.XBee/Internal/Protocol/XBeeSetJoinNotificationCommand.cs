//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Digi.XBee.Internal.Protocol
{
    
    
    /// <summary>
    /// Class to implement the XBee command " Set Join Notification ".
    /// AT Command <b>JN</b></p>Set or read the join notification setting. If enabled, the device
    /// transmits a broadcast node identification packet on power up and when joining. This action
    /// blinks the Associate LED rapidly on all devices that receive the transmission, and sends an
    /// API frame out the serial port of API devices. Digi recommends you disable this feature for
    /// large networks to prevent excessive broadcasts. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeSetJoinNotificationCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        ///  </summary>
        private int _frameId;
        
        /// <summary>
        ///  </summary>
        private bool _enableNotification;
        
        /// <summary>
        /// The frameId to set as </summary>
        /// <seecref="uint8"
        ///>
        ///  </see>
        public void SetFrameId(int frameId)
        {
            this._frameId = frameId;
        }
        
        /// <summary>
        /// The enableNotification to set as </summary>
        /// <seecref="Boolean"
        ///>
        ///  </see>
        public void SetEnableNotification(bool enableNotification)
        {
            this._enableNotification = enableNotification;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeInt8(_frameId);
            this.SerializeAtCommand("JN");
            this.SerializeBoolean(_enableNotification);
            return this.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(390);
            builder.Append("XBeeSetJoinNotificationCommand [frameId=");
            builder.Append(this._frameId);
            builder.Append(", enableNotification=");
            builder.Append(this._enableNotification);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
