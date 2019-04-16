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
    /// Class to implement the XBee command " AT ".
    /// Use this frame to query or set device parameters on the local device. This API command applies
    /// changes after running the command. You can query parameter values by sending the 0x08 AT
    /// Command frame with no parameter value field (the two-byte AT command is immediately
    /// followed by the frame checksum). 
    /// This class provides methods for processing XBee API commands.
    /// </summary>
    public class XBeeAtCommand : XBeeFrame, IXBeeCommand 
    {
        
        /// <summary>
        ///  The frame Id 
        /// </summary>
        private int _frameId;
        
        /// <summary>
        ///  Command name: two ASCII characters that identify the AT command. 
        /// </summary>
        private string _atCommand;
        
        /// <summary>
        ///  If present, indicates the requested parameter value to set the given register. If no
        /// characters are present, it queries the register. 
        /// </summary>
        private int[] _parameterValue;
        
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
        /// The atCommand to set as </summary>
        /// <seecref="AtCommand"
        ///>
        ///  </see>
        public void SetAtCommand(string atCommand)
        {
            this._atCommand = atCommand;
        }
        
        /// <summary>
        /// The parameterValue to set as </summary>
        /// <seecref="Data"
        ///>
        ///  </see>
        public void SetParameterValue(int[] parameterValue)
        {
            this._parameterValue = parameterValue;
        }
        
        /// <summary>
        /// Method for serializing the command fields </summary>
        public int[] Serialize()
        {
            this.SerializeCommand(8);
            this.SerializeInt8(_frameId);
            this.SerializeAtCommand(_atCommand);
            this.SerializeData(_parameterValue);
            return this.GetPayload();
        }
        
        public override string ToString()
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder(373);
            builder.Append("XBeeAtCommand [frameId=");
            builder.Append(this._frameId);
            builder.Append(", atCommand=");
            builder.Append(this._atCommand);
            builder.Append(", parameterValue=");
            if (this._parameterValue == null)
            {
                builder.Append("null");
            }
            else
            {
                for (int cnt = 0
                ; cnt < _parameterValue.Length; cnt++
                )
                {
                    if (cnt > 0)
                    {
                        builder.Append(' ');
                    }
                    builder.Append(string.Format("%02X", this._parameterValue[cnt]));
                }
            }
            builder.Append(']');
            return builder.ToString();
        }
    }
}
