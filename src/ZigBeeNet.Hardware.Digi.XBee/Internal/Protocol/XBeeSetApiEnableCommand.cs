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
    /// Class to implement the XBee command " Set API Enable ".
    /// AT Command <b>AP</b></p>Enables API Mode. The device ignores this command when using SPI.
    /// API mode 1 is always used. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeSetApiEnableCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        ///  </summary>
        private int _frameId;
        
        /// <summary>
        ///  </summary>
        private int _mode;
        
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
        /// The mode to set as </summary>
        /// <seecref="uint8"
        ///>
        ///  </see>
        public void SetMode(int mode)
        {
            this._mode = mode;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeInt8(_frameId);
            this.SerializeAtCommand("AP");
            this.SerializeInt8(_mode);
            return this.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(383);
            builder.Append("XBeeSetApiEnableCommand [frameId=");
            builder.Append(this._frameId);
            builder.Append(", mode=");
            builder.Append(this._mode);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
