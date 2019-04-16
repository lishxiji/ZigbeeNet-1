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
    /// Class to implement the XBee command " Get Scan Channels ".
    /// AT Command <b>SC</b></p>Set or read the list of channels to scan. Coordinator - Bit field
    /// list of channels to choose from prior to starting network. Router/End Device - Bit field list
    /// of channels scanned to find a Coordinator/Router to join. Write changes to SC using the WR
    /// command to preserve the SC setting if a power cycle occurs. 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeGetScanChannelsCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        ///  </summary>
        private int _frameId;
        
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
        /// Method for serializing the command fields </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeInt8(_frameId);
            this.SerializeAtCommand("SC");
            return this.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(296);
            builder.Append("XBeeGetScanChannelsCommand [frameId=");
            builder.Append(this._frameId);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
