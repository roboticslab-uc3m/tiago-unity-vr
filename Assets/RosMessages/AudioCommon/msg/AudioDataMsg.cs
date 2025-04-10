//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.AudioCommon
{
    [Serializable]
    public class AudioDataMsg : Message
    {
        public const string k_RosMessageName = "audio_common_msgs/AudioData";
        public override string RosMessageName => k_RosMessageName;

        public byte[] data;

        public AudioDataMsg()
        {
            this.data = new byte[0];
        }

        public AudioDataMsg(byte[] data)
        {
            this.data = data;
        }

        public static AudioDataMsg Deserialize(MessageDeserializer deserializer) => new AudioDataMsg(deserializer);

        private AudioDataMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.data, sizeof(byte), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.data);
            serializer.Write(this.data);
        }

        public override string ToString()
        {
            return "AudioDataMsg: " +
            "\ndata: " + System.String.Join(", ", data.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
