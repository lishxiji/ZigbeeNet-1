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
    /// Class to implement the XBee command " Encryption Enable ".
    /// AT Command <b>EE</b></p>Set or read the encryption enable setting.
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeEncryptionEnableResponse : XBeeFrame, IXBeeResponse 
    {
        
        /// <summary>
        /// Response field
        /// </summary>
        private int _frameId;
        
        /// <summary>
        /// Response field
        /// </summary>
        private CommandStatus _commandStatus;
        
        /// <summary>
        /// Response field
        /// </summary>
        private bool _enableEncryption;
        
        /// <summary>
        ///  Return the frameId as <see cref="System.Int32"/>
        /// </summary>
        public int GetFrameId()
        {
            return _frameId;
        }
        
        /// <summary>
        ///  Return the commandStatus as <see cref="CommandStatus"/>
        /// </summary>
        public CommandStatus GetCommandStatus()
        {
            return _commandStatus;
        }
        
        /// <summary>
        ///  Return the enableEncryption as <see cref="System.Boolean"/>
        /// </summary>
        public bool GetEnableEncryption()
        {
            return _enableEncryption;
        }
        
        /// <summary>
        /// Method for deserializing the fields for the response </summary>
        public void Deserialize(int[] incomingData)
        {
            this.InitializeDeserializer(incomingData);
            this._frameId = this.DeserializeInt8();
            DeserializeAtCommand();
            this._commandStatus = this.DeserializeCommandStatus();
            if (_commandStatus != CommandStatus.OK || IsComplete())
            {
                    return;
            }
            this._enableEncryption = this.DeserializeBoolean();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(478);
            builder.Append("XBeeEncryptionEnableResponse [frameId=");
            builder.Append(this._frameId);
            builder.Append(", commandStatus=");
            builder.Append(this._commandStatus);
            builder.Append(this._enableEncryption);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
