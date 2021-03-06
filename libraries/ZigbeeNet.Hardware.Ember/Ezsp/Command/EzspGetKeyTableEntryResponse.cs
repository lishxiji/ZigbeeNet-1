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
    using ZigBeeNet.Hardware.Ember.Ezsp.Structure;
    
    
    /// <summary>
    /// Class to implement the Ember EZSP command " getKeyTableEntry ".
    /// Retrieves the key table entry at the specified index.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetKeyTableEntryResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 113;
        
        /// <summary>
        ///  EMBER_TABLE_ENTRY_ERASED if the index is an erased key entry. EMBER_INDEX_OUT_OF_RANGE
        /// if the passed index is not valid. EMBER_SUCCESS on success.
        /// </summary>
        private EmberStatus _status;
        
        /// <summary>
        ///  The results retrieved by the stack.
        /// </summary>
        private EmberKeyStruct _keyStruct;
        
        public EzspGetKeyTableEntryResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
            _keyStruct = deserializer.DeserializeEmberKeyStruct();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        /// The keyStruct to set as <see cref="EmberKeyStruct"/> </summary>
        public void SetKeyStruct(EmberKeyStruct keyStruct)
        {
            _keyStruct = keyStruct;
        }
        
        /// <summary>
        ///  EMBER_TABLE_ENTRY_ERASED if the index is an erased key entry. EMBER_INDEX_OUT_OF_RANGE
        /// if the passed index is not valid. EMBER_SUCCESS on success.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        ///  The results retrieved by the stack.
        /// Return the keyStruct as <see cref="EmberKeyStruct"/>
        /// </summary>
        public EmberKeyStruct GetKeyStruct()
        {
            return _keyStruct;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGetKeyTableEntryResponse [status=");
            builder.Append(_status);
            builder.Append(", keyStruct=");
            builder.Append(_keyStruct);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
