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
    /// Class to implement the Ember EZSP command " getNetworkParameters ".
    /// Returns the current network parameters.
    /// This class provides methods for processing EZSP commands.
    /// </summary>
    public class EzspGetNetworkParametersResponse : EzspFrameResponse
    {
        
        public const int FRAME_ID = 40;
        
        /// <summary>
        ///  An EmberStatus value indicating success or the reason for failure.
        /// </summary>
        private EmberStatus _status;
        
        /// <summary>
        ///  An EmberNodeType value indicating the current node type.
        /// </summary>
        private EmberNodeType _nodeType;
        
        /// <summary>
        ///  The current network parameters.
        /// </summary>
        private EmberNetworkParameters _parameters;
        
        public EzspGetNetworkParametersResponse(int[] inputBuffer) : 
                base(inputBuffer)
        {
            _status = deserializer.DeserializeEmberStatus();
            _nodeType = deserializer.DeserializeEmberNodeType();
            _parameters = deserializer.DeserializeEmberNetworkParameters();
        }
        
        /// <summary>
        /// The status to set as <see cref="EmberStatus"/> </summary>
        public void SetStatus(EmberStatus status)
        {
            _status = status;
        }
        
        /// <summary>
        /// The nodeType to set as <see cref="EmberNodeType"/> </summary>
        public void SetNodeType(EmberNodeType nodeType)
        {
            _nodeType = nodeType;
        }
        
        /// <summary>
        /// The parameters to set as <see cref="EmberNetworkParameters"/> </summary>
        public void SetParameters(EmberNetworkParameters parameters)
        {
            _parameters = parameters;
        }
        
        /// <summary>
        ///  An EmberStatus value indicating success or the reason for failure.
        /// Return the status as <see cref="EmberStatus"/>
        /// </summary>
        public EmberStatus GetStatus()
        {
            return _status;
        }
        
        /// <summary>
        ///  An EmberNodeType value indicating the current node type.
        /// Return the nodeType as <see cref="EmberNodeType"/>
        /// </summary>
        public EmberNodeType GetNodeType()
        {
            return _nodeType;
        }
        
        /// <summary>
        ///  The current network parameters.
        /// Return the parameters as <see cref="EmberNetworkParameters"/>
        /// </summary>
        public EmberNetworkParameters GetParameters()
        {
            return _parameters;
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            builder.Append("EzspGetNetworkParametersResponse [status=");
            builder.Append(_status);
            builder.Append(", nodeType=");
            builder.Append(_nodeType);
            builder.Append(", parameters=");
            builder.Append(_parameters);
            builder.Append(']');
            return builder.ToString();
        }
    }
}
