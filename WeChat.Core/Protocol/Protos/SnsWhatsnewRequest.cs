﻿namespace WeChat.Core.Protocol.Protos
{
    using ProtoBuf;
    using System;

    [Serializable, ProtoContract(Name = "SnsWhatsnewRequest")]
    public class SnsWhatsnewRequest : IExtensible
    {
        private WeChat.Core.Protocol.Protos.BaseRequest _BaseRequest;
        private IExtension extensionObject;

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }

        [ProtoMember(1, IsRequired = true, Name = "BaseRequest", DataFormat = DataFormat.Default)]
        public WeChat.Core.Protocol.Protos.BaseRequest BaseRequest
        {
            get
            {
                return this._BaseRequest;
            }
            set
            {
                this._BaseRequest = value;
            }
        }
    }
}

