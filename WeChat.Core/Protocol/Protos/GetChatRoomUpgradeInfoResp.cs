﻿namespace WeChat.Core.Protocol.Protos
{
    using ProtoBuf;
    using System;
    using System.ComponentModel;

    [Serializable, ProtoContract(Name = "GetChatRoomUpgradeInfoResp")]
    public class GetChatRoomUpgradeInfoResp : IExtensible
    {
        private WeChat.Core.Protocol.Protos.BaseResponse _BaseResponse;
        private string _ChatRoomUpgradeInfo = "";
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

        [ProtoMember(2, IsRequired = false, Name = "ChatRoomUpgradeInfo", DataFormat = DataFormat.Default), DefaultValue("")]
        public string ChatRoomUpgradeInfo
        {
            get
            {
                return this._ChatRoomUpgradeInfo;
            }
            set
            {
                this._ChatRoomUpgradeInfo = value;
            }
        }
    }
}

