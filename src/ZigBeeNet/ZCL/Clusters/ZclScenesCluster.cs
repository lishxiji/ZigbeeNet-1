﻿// License text here

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZigBeeNet.DAO;
using ZigBeeNet.ZCL.Protocol;
using ZigBeeNet.ZCL.Field;
using ZigBeeNet.ZCL.Clusters.Scenes;

/**
 *Scenescluster implementation (Cluster ID 0x0005).
 *
 * The scenes cluster provides attributes and commands for setting up and recalling * scenes. Each scene corresponds to a set of stored values of specified attributes for * one or more clusters on the same end point as the scenes cluster. * <p> * In most cases scenes are associated with a particular group ID. Scenes may also * exist without a group, in which case the value 0x0000 replaces the group ID. Note * that extra care is required in these cases to avoid a scene ID collision, and that * commands related to scenes without a group may only be unicast, i.e.: they may * not be multicast or broadcast. *
 * Code is auto-generated. Modifications may be overwritten!
 */
/* Autogenerated: 13.02.2019 - 21:42 */
namespace ZigBeeNet.ZCL.Clusters
{
   public class ZclScenesCluster : ZclCluster
   {
       /**
       * The ZigBee Cluster Library Cluster ID
       */
       public static ushort CLUSTER_ID = 0x0005;

       /**
       * The ZigBee Cluster Library Cluster Name
       */
       public static string CLUSTER_NAME = "Scenes";

       /* Attribute constants */
       /**
        * The SceneCount attribute specifies the number of scenes currently in the device's        * scene table.       */
       public static ushort ATTR_SCENECOUNT = 0x0000;

       /**
        * The CurrentScene attribute holds the Scene ID of the scene last invoked.       */
       public static ushort ATTR_CURRENTSCENE = 0x0001;

       /**
        * The CurrentGroup attribute holds the Group ID of the scene last invoked, or        * 0x0000 if the scene last invoked is not associated with a group.       */
       public static ushort ATTR_CURRENTGROUP = 0x0002;

       /**
        * The SceneValid attribute indicates whether the state of the device corresponds to        * that associated with the CurrentScene and CurrentGroup attributes. TRUE        * indicates that these attributes are valid, FALSE indicates that they are not valid.        * <p>        * Before a scene has been stored or recalled, this attribute is set to FALSE. After a        * successful Store Scene or Recall Scene command it is set to TRUE. If, after a        * scene is stored or recalled, the state of the device is modified, this attribute is set to        * FALSE.       */
       public static ushort ATTR_SCENEVALID = 0x0003;

       /**
        * The most significant bit of the NameSupport attribute indicates whether or not        * scene names are supported. A value of 1 indicates that they are supported, and a        * value of 0 indicates that they are not supported.       */
       public static ushort ATTR_NAMESUPPORT = 0x0004;

       /**
        * The LastConfiguredBy attribute is 64-bits in length and specifies the IEEE address        * of the device that last configured the scene table.        * <p>        * The value 0xffffffffffffffff indicates that the device has not been configured, or        * that the address of the device that last configured the scenes cluster is not known.       */
       public static ushort ATTR_LASTCONFIGUREDBY = 0x0005;


       // Attribute initialisation
       protected override Dictionary<ushort, ZclAttribute> InitializeAttributes()
       {
           Dictionary<ushort, ZclAttribute> attributeMap = new Dictionary<ushort, ZclAttribute>(6);

           ZclClusterType scenes = ZclClusterType.GetValueById(ClusterType.SCENES);

           attributeMap.Add(ATTR_SCENECOUNT, new ZclAttribute(scenes, ATTR_SCENECOUNT, "SceneCount", ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER), true, true, false, false));
           attributeMap.Add(ATTR_CURRENTSCENE, new ZclAttribute(scenes, ATTR_CURRENTSCENE, "CurrentScene", ZclDataType.Get(DataType.UNSIGNED_8_BIT_INTEGER), true, true, false, false));
           attributeMap.Add(ATTR_CURRENTGROUP, new ZclAttribute(scenes, ATTR_CURRENTGROUP, "CurrentGroup", ZclDataType.Get(DataType.UNSIGNED_16_BIT_INTEGER), true, true, false, false));
           attributeMap.Add(ATTR_SCENEVALID, new ZclAttribute(scenes, ATTR_SCENEVALID, "SceneValid", ZclDataType.Get(DataType.BOOLEAN), true, true, false, false));
           attributeMap.Add(ATTR_NAMESUPPORT, new ZclAttribute(scenes, ATTR_NAMESUPPORT, "NameSupport", ZclDataType.Get(DataType.BITMAP_8_BIT), true, true, false, false));
           attributeMap.Add(ATTR_LASTCONFIGUREDBY, new ZclAttribute(scenes, ATTR_LASTCONFIGUREDBY, "LastConfiguredBy", ZclDataType.Get(DataType.IEEE_ADDRESS), false, true, false, false));

        return attributeMap;
       }

       /**
       * Default constructor to create a Scenes cluster.
       *
       * @param zigbeeEndpoint the {@link ZigBeeEndpoint}
       */
       public ZclScenesCluster(ZigBeeEndpoint zigbeeEndpoint)
           : base(zigbeeEndpoint, CLUSTER_ID, CLUSTER_NAME)
       {
       }

       public Task<CommandResult> GetSceneCountAsync()
       {
           return Read(_attributes[ATTR_SCENECOUNT]);
       }
       public byte GetSceneCount(long refreshPeriod)
       {
           if (_attributes[ATTR_SCENECOUNT].IsLastValueCurrent(refreshPeriod))
           {
               return (byte)_attributes[ATTR_SCENECOUNT].LastValue;
           }

           return (byte)ReadSync(_attributes[ATTR_SCENECOUNT]);
       }

       public Task<CommandResult> GetCurrentSceneAsync()
       {
           return Read(_attributes[ATTR_CURRENTSCENE]);
       }
       public byte GetCurrentScene(long refreshPeriod)
       {
           if (_attributes[ATTR_CURRENTSCENE].IsLastValueCurrent(refreshPeriod))
           {
               return (byte)_attributes[ATTR_CURRENTSCENE].LastValue;
           }

           return (byte)ReadSync(_attributes[ATTR_CURRENTSCENE]);
       }

       public Task<CommandResult> GetCurrentGroupAsync()
       {
           return Read(_attributes[ATTR_CURRENTGROUP]);
       }
       public ushort GetCurrentGroup(long refreshPeriod)
       {
           if (_attributes[ATTR_CURRENTGROUP].IsLastValueCurrent(refreshPeriod))
           {
               return (ushort)_attributes[ATTR_CURRENTGROUP].LastValue;
           }

           return (ushort)ReadSync(_attributes[ATTR_CURRENTGROUP]);
       }

       public Task<CommandResult> GetSceneValidAsync()
       {
           return Read(_attributes[ATTR_SCENEVALID]);
       }
       public bool GetSceneValid(long refreshPeriod)
       {
           if (_attributes[ATTR_SCENEVALID].IsLastValueCurrent(refreshPeriod))
           {
               return (bool)_attributes[ATTR_SCENEVALID].LastValue;
           }

           return (bool)ReadSync(_attributes[ATTR_SCENEVALID]);
       }

       public Task<CommandResult> GetNameSupportAsync()
       {
           return Read(_attributes[ATTR_NAMESUPPORT]);
       }
       public byte GetNameSupport(long refreshPeriod)
       {
           if (_attributes[ATTR_NAMESUPPORT].IsLastValueCurrent(refreshPeriod))
           {
               return (byte)_attributes[ATTR_NAMESUPPORT].LastValue;
           }

           return (byte)ReadSync(_attributes[ATTR_NAMESUPPORT]);
       }

       public Task<CommandResult> GetLastConfiguredByAsync()
       {
           return Read(_attributes[ATTR_LASTCONFIGUREDBY]);
       }
       public IeeeAddress GetLastConfiguredBy(long refreshPeriod)
       {
           if (_attributes[ATTR_LASTCONFIGUREDBY].IsLastValueCurrent(refreshPeriod))
           {
               return (IeeeAddress)_attributes[ATTR_LASTCONFIGUREDBY].LastValue;
           }

           return (IeeeAddress)ReadSync(_attributes[ATTR_LASTCONFIGUREDBY]);
       }


       /**
       * The Add Scene Command
       *
        * The Add Scene command shall be addressed to a single device (not a group).       *
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @param transitionTime {@link ushort} Transition time
       * @param sceneName {@link string} Scene Name
       * @param extensionFieldSets {@link List<ExtensionFieldSet>} Extension field sets
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> AddSceneCommand(ushort groupID, byte sceneID, ushort transitionTime, string sceneName, List<ExtensionFieldSet> extensionFieldSets)
       {
           AddSceneCommand command = new AddSceneCommand();

       // Set the fields
           command.GroupID = groupID;
           command.SceneID = sceneID;
           command.TransitionTime = transitionTime;
           command.SceneName = sceneName;
           command.ExtensionFieldSets = extensionFieldSets;

           return Send(command);
       }

       /**
       * The View Scene Command
       *
        * The View Scene command shall be addressed to a single device (not a group).       *
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> ViewSceneCommand(ushort groupID, byte sceneID)
       {
           ViewSceneCommand command = new ViewSceneCommand();

       // Set the fields
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The Remove Scene Command
       *
        * The Remove All Scenes may be addressed to a single device or to a group.       *
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> RemoveSceneCommand(ushort groupID, byte sceneID)
       {
           RemoveSceneCommand command = new RemoveSceneCommand();

       // Set the fields
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The Remove All Scenes Command
       *
        * The Remove All Scenes may be addressed to a single device or to a group.       *
       * @param groupID {@link ushort} Group ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> RemoveAllScenesCommand(ushort groupID)
       {
           RemoveAllScenesCommand command = new RemoveAllScenesCommand();

       // Set the fields
           command.GroupID = groupID;

           return Send(command);
       }

       /**
       * The Store Scene Command
       *
        * The Store Scene command may be addressed to a single device or to a group.       *
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> StoreSceneCommand(ushort groupID, byte sceneID)
       {
           StoreSceneCommand command = new StoreSceneCommand();

       // Set the fields
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The Recall Scene Command
       *
        * The Recall Scene command may be addressed to a single device or to a group.       *
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> RecallSceneCommand(ushort groupID, byte sceneID)
       {
           RecallSceneCommand command = new RecallSceneCommand();

       // Set the fields
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The Get Scene Membership Command
       *
        * The Get Scene Membership command can be used to find an unused scene        * number within the group when no commissioning tool is in the network, or for a        * commissioning tool to get used scenes for a group on a single device or on all        * devices in the group.       *
       * @param groupID {@link ushort} Group ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> GetSceneMembershipCommand(ushort groupID)
       {
           GetSceneMembershipCommand command = new GetSceneMembershipCommand();

       // Set the fields
           command.GroupID = groupID;

           return Send(command);
       }

       /**
       * The Add Scene Response
       *
       * @param status {@link byte} Status
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> AddSceneResponse(byte status, ushort groupID, byte sceneID)
       {
           AddSceneResponse command = new AddSceneResponse();

       // Set the fields
           command.Status = status;
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The View Scene Response
       *
       * @param status {@link byte} Status
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @param transitionTime {@link ushort} Transition time
       * @param sceneName {@link string} Scene Name
       * @param extensionFieldSets {@link List<ExtensionFieldSet>} Extension field sets
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> ViewSceneResponse(byte status, ushort groupID, byte sceneID, ushort transitionTime, string sceneName, List<ExtensionFieldSet> extensionFieldSets)
       {
           ViewSceneResponse command = new ViewSceneResponse();

       // Set the fields
           command.Status = status;
           command.GroupID = groupID;
           command.SceneID = sceneID;
           command.TransitionTime = transitionTime;
           command.SceneName = sceneName;
           command.ExtensionFieldSets = extensionFieldSets;

           return Send(command);
       }

       /**
       * The Remove Scene Response
       *
       * @param status {@link byte} Status
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> RemoveSceneResponse(byte status, ushort groupID, byte sceneID)
       {
           RemoveSceneResponse command = new RemoveSceneResponse();

       // Set the fields
           command.Status = status;
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The Remove All Scenes Response
       *
       * @param status {@link byte} Status
       * @param groupID {@link ushort} Group ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> RemoveAllScenesResponse(byte status, ushort groupID)
       {
           RemoveAllScenesResponse command = new RemoveAllScenesResponse();

       // Set the fields
           command.Status = status;
           command.GroupID = groupID;

           return Send(command);
       }

       /**
       * The Store Scene Response
       *
       * @param status {@link byte} Status
       * @param groupID {@link ushort} Group ID
       * @param sceneID {@link byte} Scene ID
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> StoreSceneResponse(byte status, ushort groupID, byte sceneID)
       {
           StoreSceneResponse command = new StoreSceneResponse();

       // Set the fields
           command.Status = status;
           command.GroupID = groupID;
           command.SceneID = sceneID;

           return Send(command);
       }

       /**
       * The Get Scene Membership Response
       *
       * @param status {@link byte} Status
       * @param capacity {@link byte} Capacity
       * @param groupID {@link ushort} Group ID
       * @param sceneCount {@link byte} Scene count
       * @param sceneList {@link List<byte>} Scene list
       * @return the Task<CommandResult> command result Task
       */
       public Task<CommandResult> GetSceneMembershipResponse(byte status, byte capacity, ushort groupID, byte sceneCount, List<byte> sceneList)
       {
           GetSceneMembershipResponse command = new GetSceneMembershipResponse();

       // Set the fields
           command.Status = status;
           command.Capacity = capacity;
           command.GroupID = groupID;
           command.SceneCount = sceneCount;
           command.SceneList = sceneList;

           return Send(command);
       }

       public override ZclCommand GetCommandFromId(int commandId)
       {
           switch (commandId)
           {
               case 0: // ADD_SCENE_COMMAND
                   return new AddSceneCommand();
               case 1: // VIEW_SCENE_COMMAND
                   return new ViewSceneCommand();
               case 2: // REMOVE_SCENE_COMMAND
                   return new RemoveSceneCommand();
               case 3: // REMOVE_ALL_SCENES_COMMAND
                   return new RemoveAllScenesCommand();
               case 4: // STORE_SCENE_COMMAND
                   return new StoreSceneCommand();
               case 5: // RECALL_SCENE_COMMAND
                   return new RecallSceneCommand();
               case 6: // GET_SCENE_MEMBERSHIP_COMMAND
                   return new GetSceneMembershipCommand();
                   default:
                       return null;
           }
       }

       public ZclCommand getResponseFromId(int commandId)
       {
           switch (commandId)
           {
               case 0: // ADD_SCENE_RESPONSE
                   return new AddSceneResponse();
               case 1: // VIEW_SCENE_RESPONSE
                   return new ViewSceneResponse();
               case 2: // REMOVE_SCENE_RESPONSE
                   return new RemoveSceneResponse();
               case 3: // REMOVE_ALL_SCENES_RESPONSE
                   return new RemoveAllScenesResponse();
               case 4: // STORE_SCENE_RESPONSE
                   return new StoreSceneResponse();
               case 5: // GET_SCENE_MEMBERSHIP_RESPONSE
                   return new GetSceneMembershipResponse();
                   default:
                       return null;
           }
       }
   }
}