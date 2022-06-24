﻿namespace WeChat.Core.Protocol.Protos
{
    using ProtoBuf;
    using System;
    using System.Collections.Generic;

    [Serializable, ProtoContract(Name = "GetAPPListResponse")]
    public class GetAPPListResponse : IExtensible
    {
        private WeChat.Core.Protocol.Protos.BaseResponse _BaseResponse;
        private uint _Count;
        private uint _Hash;
        private readonly List<APPItem> _List = new List<APPItem>();
        private IExtension extensionObject;

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }

        [ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
        public WeChat.Core.Protocol.Protos.BaseResponse BaseResponse
        {
            get
            {
                return this._BaseResponse;
            }
            set
            {
                this._BaseResponse = value;
            }
        }

        [ProtoMember(2, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
        public uint Count
        {
            get
            {
                return this._Count;
            }
            set
            {
                this._Count = value;
            }
        }

        [ProtoMember(4, IsRequired = true, Name = "Hash", DataFormat = DataFormat.TwosComplement)]
        public uint Hash
        {
            get
            {
                return this._Hash;
            }
            set
            {
                this._Hash = value;
            }
        }

        [ProtoMember(3, Name = "List", DataFormat = DataFormat.Default)]
        public List<APPItem> List
        {
            get
            {
                return this._List;
            }
        }
    }
}

