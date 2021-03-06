//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:3.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZigBeeNet.Hardware.Ember.Ezsp.Command
{
    using ZigBeeNet.Hardware.Ember.Internal.Serializer;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " getAddressTableRemoteEui64 ".
    /// Gets the EUI64 of an address table entry.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetAddressTableRemoteEui64Request : EzspFrameRequest
    {
        
        public const int FRAME_ID = 94;
        
        /// <summary>
        ///  The index of an address table entry.
        /// </summary>
        private int _addressTableIndex;
        
        private EzspSerializer _serializer;
        
        public EzspGetAddressTableRemoteEui64Request()
        {
            _frameId = FRAME_ID;
            _serializer = new EzspSerializer();
        }
        
        /// <summary>
        /// The addressTableIndex to set as <see cref="uint8_t"/> </summary>
        public void SetAddressTableIndex(int addressTableIndex)
        {
            _addressTableIndex = addressTableIndex;
        }
        
        /// <summary>
        ///  The index of an address table entry.
        /// Return the addressTableIndex as <see cref="System.Int32"/>
        /// </summary>
        public int GetAddressTableIndex()
        {
            return _addressTableIndex;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public override int[] Serialize()
        {
            SerializeHeader(_serializer);
            _serializer.SerializeUInt8(_addressTableIndex);
            return _serializer.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGetAddressTableRemoteEui64Request [addressTableIndex=");
            builder.Append(_addressTableIndex);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
